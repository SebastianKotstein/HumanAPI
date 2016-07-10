using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKotstein.Kinect.API.Core
{
    public class BodyEventArgs : EventArgs
    {
        private readonly IBodyController bc;
        private readonly ulong trackingId;

        public BodyEventArgs(IBodyController bc, ulong trackingId)
        {
            this.bc = bc;
            this.trackingId = trackingId;
        }

        public ulong GetTrackingId()
        {
            return this.trackingId;
        }

        public IBodyController GetBodyController()
        {
            return this.bc;
        }

    }
}
