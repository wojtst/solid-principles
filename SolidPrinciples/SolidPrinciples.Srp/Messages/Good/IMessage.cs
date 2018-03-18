using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Good
{
    public interface IMessage
    {
        string Content { get; }
        IEnumerable<string> ToAddresses { get; }
    }
}