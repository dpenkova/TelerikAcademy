using System;

namespace CustomException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private readonly T start;
        private readonly T end;

        public T Start
        {
            get
            { return this.start; }
        }

        public T End
        {
            get
            { return this.end; }
        }

        public InvalidRangeException(string message, T startRange, T endRange, Exception causeException = null)
            : base(message, causeException)
        {
            this.start = startRange;
            this.end = endRange;
        }
    }
}
