using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cynox.IO.Connections
{
    /// <summary>
    /// Represents a simple connection interface for generic use.
    /// </summary>
	public interface IConnection : IDisposable
	{
        /// <summary>
        /// Reports that data has been received.
        /// </summary>
        event Action<object, ConnectionDataReceivedEventArgs> DataReceived;

        /// <summary>
        /// Returns true if currently open/connected.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Opens the connection.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ConnectionException"></exception>
        void Connect();

        /// <summary>
        /// Closes the connection.
        /// </summary>
        /// <exception cref="ConnectionException"></exception>
        void Disconnect();

        /// <summary>
        /// Sends data.
        /// </summary>
        /// <param name="data">Data to send.</param>
        /// <returns></returns>
		/// <exception cref="ConnectionException"></exception>
        void Send(IList<byte> data);

        /// <summary>
        /// Returns configuration details about the connection.
        /// </summary>
        /// <returns></returns>
		string ToString();
	}
}
