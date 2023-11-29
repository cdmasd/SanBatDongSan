using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public static class Mail
    {
        // Mail xác nhận code đăng kí
        public static string MailRegister(string toEmail, string code)
        {
            try
            {
                // Khởi tạo đối tượng MailMessage để tạo email.
                MailMessage Msg = new MailMessage();

                // Đặt người gửi email.
                Msg.From = new MailAddress("tienphanps28044@gmail.com");

                // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
                Msg.To.Add(toEmail.Trim());

                // Đặt tiêu đề của email.
                Msg.Subject = "Mã xác thực đăng kí phần mềm quản lý bất động sản";

                // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
                Msg.Body = @"<!DOCTYPE html>
<html>
<head>
  <meta charset=""utf-8"">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        .container {
            background-color: #ffffff;
            width: 80%;
            max-width: 600px;
            margin: 20px auto;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            background-color: #33CCFF;
            padding: 10px 20px;
            text-align: center;
            font-size: 24px;
            font-weight: bold;
        }
        .content {
            padding: 20px;
            text-align: center;
            line-height: 1.6;
        }
        .footer {
            background-color: #eeeeee;
            padding: 10px 20px;
            text-align: center;
            font-size: 12px;
        }
        .confirmation-code {
            font-size: 20px;
            color: #333;
            margin: 20px 0;
            padding: 10px;
            border: 1px dashed #333;
            display: inline-block;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            Mã Xác Nhận
        </div>
        <div class=""content"">
            <p>Mã xác nhận của bạn là:</p>
            <div class=""confirmation-code"">" + code + @"</div>
        </div>
        <div class=""footer"">
            Đây là email tự động, vui lòng không trả lời. Nếu bạn cần hỗ trợ, xin vui lòng liên hệ sử dụng chức năng hỗ trợ trong ứng dụng.
        </div>
    </div>
</body>
</html>";
                Msg.IsBodyHtml = true;
                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(Msg);
                }
                return $"Đã gửi mã xác thực vào địa chỉ email : {toEmail}";
            }
            catch (Exception ex)
            {
                // Nếu lỗi là do lỗi khác, hãy hiển thị thông báo lỗi.
                return "Đã phát sinh lỗi" + ex.Message;
            }
        }
        // Mail khôi phục tài khoản
        public static string MailRecovery(string toEmail, string newpass)
        {
            try
            {
                // Khởi tạo đối tượng MailMessage để tạo email.
                MailMessage Msg = new MailMessage();

                // Đặt người gửi email.
                Msg.From = new MailAddress("tienphanps28044@gmail.com");

                // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
                Msg.To.Add(toEmail.Trim());

                // Đặt tiêu đề của email.
                Msg.Subject = "Khôi phục mật khẩu phần mềm quản lý bất động sản";

                // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
                Msg.Body = @"<!DOCTYPE html>
<html>
<head>
  <meta charset=""utf-8"">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        .container {
            background-color: #ffffff;
            width: 80%;
            max-width: 600px;
            margin: 20px auto;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            background-color: #33CCFF;
            padding: 10px 20px;
            text-align: center;
            font-size: 24px;
            font-weight: bold;
        }
        .content {
            padding: 20px;
            text-align: center;
            line-height: 1.6;
        }
        .footer {
            background-color: #eeeeee;
            padding: 10px 20px;
            text-align: center;
            font-size: 12px;
        }
        .confirmation-code {
            font-size: 20px;
            color: #333;
            margin: 20px 0;
            padding: 10px;
            border: 1px dashed #333;
            display: inline-block;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            Khôi Phục Mật Khẩu
        </div>
        <div class=""content"">
            <p>Mật khẩu mới của bạn là:</p>
            <div class=""confirmation-code"">" + newpass + @"</div>
        </div>
        <div class=""footer"">
            Đây là email tự động, vui lòng không trả lời. Nếu bạn cần hỗ trợ, xin vui lòng liên hệ sử dụng chức năng hỗ trợ trong ứng dụng.
        </div>
    </div>
</body>
</html>";
                Msg.IsBodyHtml = true;
                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(Msg);
                }
                return $"Đã gửi mật khẩu mới vào địa chỉ email : {toEmail}";
            }
            catch
            {
                // Nếu lỗi là do lỗi khác, hãy hiển thị thông báo lỗi.
                return "Không tìm thấy email trong hệ thống";
            }
        }
        // Mail thông báo lí do bị từ chối
        public static void MailRejected(string toEmail, string id, string reason)
        {
            // Khởi tạo đối tượng MailMessage để tạo email.
            MailMessage Msg = new MailMessage();

            // Đặt người gửi email.
            Msg.From = new MailAddress("tienphanps28044@gmail.com");

            // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
            Msg.To.Add(toEmail.Trim());

            // Đặt tiêu đề của email.
            Msg.Subject = $"Bài đăng {id} đã bị từ chối";

            // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
            Msg.Body = @"<!DOCTYPE html>
<html>
<head>
  <meta charset=""utf-8"">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        .container {
            background-color: #ffffff;
            width: 80%;
            max-width: 600px;
            margin: 20px auto;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .content {
            padding: 20px;
            text-align: center;
            line-height: 1.6;
        }
        .footer {
            background-color: #eeeeee;
            padding: 10px 20px;
            text-align: center;
            font-size: 12px;
        }
        .confirmation-code {
            font-size: 20px;
            color: #333;
            margin: 20px 0;
            padding: 10px;
            border: 1px dashed #333;
            display: inline-block;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""content"">
            <p>Bài đăng " + id + @" bị từ chối vì lí do """ + reason + @"""</p>
        </div>
        <div class=""footer"">
            Đây là email tự động, vui lòng không trả lời. Nếu bạn cần hỗ trợ, xin vui lòng liên hệ sử dụng chức năng hỗ trợ trong ứng dụng.
        </div>
    </div>
</body>
</html>";
            Msg.IsBodyHtml = true;
            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(Msg);
            }
        }
        public static void MailPayment(string toEmail,string name,string tiennap,string sodu)
        {
            // Khởi tạo đối tượng MailMessage để tạo email.
            MailMessage Msg = new MailMessage();

            // Đặt người gửi email.
            Msg.From = new MailAddress("tienphanps28044@gmail.com");

            // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
            Msg.To.Add(toEmail.Trim());

            // Đặt tiêu đề của email.
            Msg.Subject = "Thanh toán thành công";

            // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
            Msg.Body = @"<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf-8"">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        .container {
            background-color: #ffffff;
            width: 80%;
            max-width: 6000px;
            margin: 20px auto;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            background-color: #33CCFF;
            padding: 10px 20px;
            text-align: center;
            font-size: 24px;
            font-weight: bold;
        }
        .content {
            padding: 20px;
            text-align: center;
            line-height: 1.6;
        }
        .footer {
            background-color: #eeeeee;
            padding: 10px 20px;
            text-align: center;
            font-size: 12px;
        }
        .confirmation-code {
      		text-align: left;
            font-size: 15px;
            color: #333;
            margin: 20px 0;
            padding: 10px;
      		min-width : 200px;
            border: 1px dashed #333;
            display: inline-block;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            Thanh toán thành công
        </div>
        <div class=""content"">
            <div class=""confirmation-code"">
              	<strong>Email : " + toEmail + @"</strong><br>
                <strong>Họ tên : " + name + @"</strong><br>
                <strong>Số tiền nạp : " + tiennap + @"</strong><br>
                <strong>Số dư còn lại : " + sodu + @"</strong>
            </div>
        </div>
        <div class=""footer"">
            Đây là email tự động, vui lòng không trả lời. Nếu bạn cần hỗ trợ, xin vui lòng liên hệ sử dụng chức năng hỗ trợ trong ứng dụng.
        </div>
    </div>
</body>
</html>";
            Msg.IsBodyHtml = true;
            using (SmtpClient client = new SmtpClient())
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(Msg);
            }
        }
    }
}
