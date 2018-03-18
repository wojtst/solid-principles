namespace SolidPrinciples.Srp.Messages.Good.Senders
{
    public interface IMessageSender
    {
        bool Send(IMessage message);
    }
}