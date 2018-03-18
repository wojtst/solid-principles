using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Good
{
    public class SmtpMessage : IEmailMessage
    {
        public SmtpMessage(
            string subject,
            string content,
            IEnumerable<string> toAddresses,
            IEnumerable<string> ccAddresses = null)
        {
            Subject = subject;
            Content = content;
            ToAddresses = toAddresses;
            CcAddresses = ccAddresses;
        }

        public string Subject { get; }
        public string Content { get; }

        public IEnumerable<string> ToAddresses { get; }
        public IEnumerable<string> CcAddresses { get; }
    }
}