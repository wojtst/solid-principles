using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Bad
{
    public interface IMessage
    {
        string Content { get; }
        IEnumerable<string> ToAddresses { get; }

        bool Send();
    }
}