using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.Service.Services
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendAMailToCondition(List<string> customers,MailDto mailDto, bool isBodyHtml = true)
        {
            List<string> notNullCustomers = new List<string>();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i] != null)
                {
                    notNullCustomers.Add(customers[i]);
                }
            }

            string[] tos = new string[notNullCustomers.Count];

            for (int i = 0; i < notNullCustomers.Count; i++)
            {
                tos[i] = notNullCustomers[i];
            }
            await SendMailAsync(tos, mailDto.Subject, mailDto.Body, isBodyHtml);
        }

        public async Task SendMailAsync(string? to, string subject, string body, bool isBodyHtml = true)
        {
            await SendMailAsync(new[] { to }, subject, body, isBodyHtml);
        }

        public async Task SendMailAsync(string[]? tos, string subject, string body, bool isBodyHtml = true)
        {
            MailMessage mail = new();
            mail.IsBodyHtml = isBodyHtml;
            foreach (string to in tos)
                mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new(_configuration["Mail:Username"], "Sinemis Information", System.Text.Encoding.UTF8);

            SmtpClient smtp = new();
            smtp.Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]);
            smtp.Port =int.Parse(_configuration["Mail:Port"]);
            smtp.EnableSsl = true;
            smtp.Host = _configuration["Mail:Host"];

            await smtp.SendMailAsync(mail);
        }
    }
}
