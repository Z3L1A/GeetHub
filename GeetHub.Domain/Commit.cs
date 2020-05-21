using System;

namespace GeetHub.Domain
{
    public sealed class Commit
    {
        public Commit(string message, Guid userId)
        {
            Hash = Guid.NewGuid();
            Date = DateTimeOffset.UtcNow;
            Message = message;
            UserId = userId;
        }

        public Guid Hash { get; }

        public string Message { get; set; }

        public DateTimeOffset Date { get; set; }

        public Guid UserId { get; set; }
    }
}