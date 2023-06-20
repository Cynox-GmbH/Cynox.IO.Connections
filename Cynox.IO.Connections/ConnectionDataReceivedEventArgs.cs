using System;
using System.Collections.Generic;
using System.Text;

namespace Cynox.IO.Connections
{
    /// <summary>
    /// Event argument for <see cref="IConnection.DataReceived"/> event.
    /// </summary>
    public class ConnectionDataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Received data.
        /// </summary>
        public IList<byte> Data { get; }

        /// <summary>
        /// Creates a new instance providing the data that has been received.
        /// </summary>
        /// <param name="data"></param>
        public ConnectionDataReceivedEventArgs(IList<byte> data)
        {
            Data = data;
        }
    }
}
