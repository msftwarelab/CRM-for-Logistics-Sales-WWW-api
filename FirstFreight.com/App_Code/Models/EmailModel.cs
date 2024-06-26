﻿using System.Collections.Generic;

namespace Models
{

    public class SendEmailRequest
    {
        public int SubscriberId { get; set; }
        public string Subject { get; set; }
        public int DealId { get; set; }
        public Recipient Sender { get; set; }
        public List<Recipient> UserRecipients { get; set; }
        public List<Recipient> ContactRecipients { get; set; }
        public List<Recipient> OtherRecipients { get; set; } 
        public string HtmlBody { get; set; } 
    }

    public class SendEmailResponse
    {
        public int EmailId { get; set; }
        public string SuccessMessageIds { get; set; }
        public bool IsError { get; set; }
        public string ErrorEmails { get; set; }
    }

    public class EmailFilter
    {
        public int DealId { get; set; }
        public int UserId { get; set; }
        public int SentBy { get; set; }
        public int ContactId { get; set; }

        // paging
        public int RecordsPerPage { get; set; }
        public int CurrentPage { get; set; }
    }

    public class EmailModel : FirstFreight.App_Code.Email
    {
        public string UserName { get; set; }
        public string ContactName { get; set; }
        public string SentByName { get; set; }
    }

    public class Recipient
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
    }

}
