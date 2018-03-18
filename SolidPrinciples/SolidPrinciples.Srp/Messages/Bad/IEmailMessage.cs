using System.Collections.Generic;

namespace SolidPrinciples.Srp.Messages.Bad
{
    public interface IEmailMessage : IMessage
    {
        string Subject { get; }
        IEnumerable<string> CcAddresses { get; }
    }
}