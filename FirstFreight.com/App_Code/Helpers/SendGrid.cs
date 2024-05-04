using Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Helpers
{
    public class SendGridHelper
    {

        public bool SendEmail(SendEmailRequest request)
        {
            // send to users
            if (request.UserRecipients != null)
                foreach (var recipient in request.UserRecipients)
                {
                    SendEmail(recipient, request);
                }

            // send to contact recipient
            if (request.ContactRecipients != null)
                foreach (var recipient in request.ContactRecipients)
                {
                    SendEmail(recipient, request);
                }

            // send to other recipient
            if (request.OtherRecipients != null)
                foreach (var recipient in request.OtherRecipients)
                {
                    SendEmail(recipient, request);
                }

            return true;
        }

        private void SendEmail(Recipient recipient, SendEmailRequest request)
        {
            var client = new SendGridClient("SendGridClient key");
            var from = new EmailAddress(request.Sender.EmailAddress, request.Sender.Name);
            var subject = request.Subject;
            var to = new EmailAddress(recipient.EmailAddress);
            var htmlContent = request.HtmlBody;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}
