using System;
using System.Runtime.Serialization;

namespace EXCEPTION_task1.Services
{
    [Serializable]
    internal class SameBookalreadyAddedExpection : Exception
    {
        private string v;
        private SameBookalreadyAddedExpection sameBookalreadyAddedExpection;

        public SameBookalreadyAddedExpection()
        {
        }

        public SameBookalreadyAddedExpection(string message) : base(message)
        {
        }

        public SameBookalreadyAddedExpection(string v, SameBookalreadyAddedExpection sameBookalreadyAddedExpection)
        {
            this.v = v;
            this.sameBookalreadyAddedExpection = sameBookalreadyAddedExpection;
        }

        public SameBookalreadyAddedExpection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SameBookalreadyAddedExpection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}