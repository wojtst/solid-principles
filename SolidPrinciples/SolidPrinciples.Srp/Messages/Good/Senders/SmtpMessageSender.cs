namespace SolidPrinciples.Srp.Messages.Good.Senders
{
    public class SmtpMessageSender : IMessageSender
    {
        public bool Send(IMessage message)
        {
            // Actually send a message
            return true;
        }
    }
}