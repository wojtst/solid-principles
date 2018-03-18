using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Good
{
    public class SmsMessage : IMessage
    {
        public SmsMessage(
            string content,
            IEnumerable<string> toAddresses)
        {
            Content = content;
            ToAddresses = toAddresses;
        }

        public string Content { get; }
        public IEnumerable<string> ToAddresses { get; }
    }
}