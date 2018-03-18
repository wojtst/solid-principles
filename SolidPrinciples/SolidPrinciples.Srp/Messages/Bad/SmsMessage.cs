using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Bad
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

        public bool Send()
        {
            // Actually send a message
            return true;
        }
    }
}