using System;

namespace Cynox.IO.Connections
{
	/// <summary>
	/// Common exception for types that implement <see cref="IConnection"/>.
	/// Inner exception should be used to provide details.
	/// </summary>
	public class ConnectionException : Exception
	{
		/// <inheritdoc/>
		public ConnectionException(string message) : base(message)
		{ }

		/// <inheritdoc/>
		public ConnectionException(string message, Exception innerException) : base(message, innerException)
		{ }
	}
}
