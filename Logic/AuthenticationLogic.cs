using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class AuthenticationLogic
    {
        private EmployeeDao employeeDao;

        public AuthenticationLogic()
        {
            employeeDao = new EmployeeDao();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return employeeDao.GetEmployeeByEmail(email);
        }

        public Employee AuthenticateUser(string email, string password)
        {
            Employee employee = employeeDao.GetEmployeeByEmail(email);

            if (employee != null)
            {
                if (employee.Password == password)
                {
                    return employee;
                }
            }

            return null;
        }


        public Employee AuthenticateEmail(string email)
        {
            Employee employee = employeeDao.GetEmployeeByEmail(email);

            if (employee != null)
            {
                if (employee.Email == email)
                {
                    return employee;
                }
            }
            return null;
        }


        public bool UpdatePassword(string email, string newPassword)
        {

            return employeeDao.UpdateEmployeePassword(email, newPassword);
        }

        public string GetHashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        public void SendPasswordResetEmail(string toEmail, string resetCode)
        {
            string smtpAddress = "mail.smtp2go.com";
            int smtpPort = 2525;
            bool enableSSL = true;

            string emailFrom = "gardengrouper@gmail.com";
            string password = "hkaetCJ3olVrsk3q";
            string subject = "Password Reset Request";
            string body = $"Your password reset code is: {resetCode}\nPlease use this code to reset your password.";

            using (SmtpClient smtp = new SmtpClient(smtpAddress, smtpPort))
            {
                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;

                using (MailMessage message = new MailMessage(emailFrom, toEmail, subject, body))
                {
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException("Could not send password reset email.", ex);
                    }
                }
            }
        }
    }
}
