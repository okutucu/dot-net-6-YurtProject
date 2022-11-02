using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IMailService
    {
        Task SendMailAsync(string to, string subject, string body,bool isBodyHtml= true);
        Task SendMailAsync(string[] tos, string subject, string body, bool isBodyHtml= true);
        Task SendAMailToCondition(List<string> customers, MailDto mailDto, bool isBodyHtml = true);

    }
}
