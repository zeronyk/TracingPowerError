using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Skm.Holo
{
	public static partial class DataAccess
	{
		public static bool OverrideZfMaximumLengthOfDeserialize = false;

		private const ushort SMOB_VERSION = 1;

		public enum SerializerType
		{
#if NET45
			/// <summary>
			/// Nicht mehr verwenden! (0.3.3)
			/// </summary>
			ProtobufNet,
#endif
			ZeroFormatter
		}
	}
}