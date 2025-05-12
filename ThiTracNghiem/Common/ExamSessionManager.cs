using BusinessLogicLayer;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace ThiTracNghiem.Common
{
    public class ExamSessionManager
    {
        /// <summary>
        /// Phương thức kiểm tra và cập nhật trạng thái kỳ thi dựa trên thời gian
        /// </summary>
        public static void UpdateExamSessionStatus()
        {
            try
            {
                // Lấy tất cả kỳ thi
                DataTable dtExamSessions = BExamSession.GetAll();
                
                if (dtExamSessions == null || dtExamSessions.Rows.Count == 0)
                    return;
                    
                DateTime now = DateTime.Now;
                string systemUser = "System";
                
                foreach (DataRow row in dtExamSessions.Rows)
                {
                    int sessionId = Convert.ToInt32(row["SessionID"]);
                    string status = row["Status"].ToString();
                    DateTime startTime = Convert.ToDateTime(row["StartTime"]);
                    DateTime endTime = Convert.ToDateTime(row["EndTime"]);
                    
                    // Nếu kỳ thi đã hủy hoặc đã hoàn thành, bỏ qua
                    if (status == "Cancelled" || status == "Completed")
                        continue;
                        
                    // Nếu kỳ thi đã đến thời gian bắt đầu nhưng chưa kết thúc
                    if (now >= startTime && now < endTime && status != "InProgress")
                    {
                        BExamSession.UpdateStatus(sessionId, "InProgress", systemUser);
                    }
                    // Nếu kỳ thi đã kết thúc
                    else if (now >= endTime && status != "Completed")
                    {
                        BExamSession.UpdateStatus(sessionId, "Completed", systemUser);
                        
                        // Cập nhật trạng thái người dùng chưa hoàn thành bài thi
                        UpdateUserExamSessionStatusForCompletedExam(sessionId);
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error updating exam session status: " + ex.Message);
                XtraMessageBox.Show("Lỗi khi cập nhật trạng thái kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Phương thức cập nhật trạng thái người dùng trong kỳ thi đã kết thúc
        /// </summary>
        /// <param name="sessionId">ID của kỳ thi</param>
        private static void UpdateUserExamSessionStatusForCompletedExam(int sessionId)
        {
            try
            {
                DataTable dtUsers = BUserExamSession.GetBySession(sessionId);
                string systemUser = "System";
                
                foreach (DataRow row in dtUsers.Rows)
                {
                    int userId = Convert.ToInt32(row["UserID"]);
                    string status = row["Status"].ToString();
                    
                    // Nếu người dùng đã đăng ký nhưng chưa bắt đầu hoặc chưa hoàn thành
                    if (status == "Registered" || status == "Started")
                    {
                        BUserExamSession.UpdateStatus(userId, sessionId, "Absent", null, DateTime.Now, systemUser);
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error updating user exam session status: " + ex.Message);
                XtraMessageBox.Show("Lỗi khi cập nhật trạng thái người dùng trong kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Phương thức cập nhật trạng thái người dùng trong kỳ thi
        /// </summary>
        public static void UpdateUserExamSessionStatus()
        {
            try
            {
                // Lấy các kỳ thi đang diễn ra
                DataTable dtExamSessions = BExamSession.GetCurrent();
                
                if (dtExamSessions == null || dtExamSessions.Rows.Count == 0)
                    return;
                    
                string systemUser = "System";
                DateTime now = DateTime.Now;
                
                foreach (DataRow row in dtExamSessions.Rows)
                {
                    int sessionId = Convert.ToInt32(row["SessionID"]);
                    DateTime endTime = Convert.ToDateTime(row["EndTime"]);
                    
                    // Lấy danh sách người dùng trong kỳ thi
                    DataTable dtUsers = BUserExamSession.GetBySession(sessionId);
                    
                    foreach (DataRow userRow in dtUsers.Rows)
                    {
                        int userId = Convert.ToInt32(userRow["UserID"]);
                        string status = userRow["Status"].ToString();
                        DateTime? startTime = null;
                        
                        if (userRow["StartTime"] != DBNull.Value)
                            startTime = Convert.ToDateTime(userRow["StartTime"]);
                        
                        // Nếu người dùng đã bắt đầu làm bài
                        if (status == "Started" && startTime.HasValue)
                        {
                            // Kiểm tra thời gian làm bài đã hết chưa
                            int timeLimit = Convert.ToInt32(row["TimeLimit"]);
                            DateTime expectedEndTime = startTime.Value.AddMinutes(timeLimit);
                            
                            if (now >= expectedEndTime)
                            {
                                // Cập nhật trạng thái người dùng thành "Completed"
                                BUserExamSession.UpdateStatus(userId, sessionId, "Completed", startTime, now, systemUser);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error updating user exam session status: " + ex.Message);
                XtraMessageBox.Show("Lỗi khi cập nhật trạng thái người dùng trong kỳ thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
