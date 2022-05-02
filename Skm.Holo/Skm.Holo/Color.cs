using System;
using System.Globalization;

namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Color
	{
		#region Statische Farben

		[ZeroFormatter.IgnoreFormat]
		public static Color Black = new Color(0f, 0f, 0f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color White = new Color(1f, 1f, 1f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color Red = new Color(1f, 0f, 0f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color Green = new Color(0f, 1f, 0f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color Blue = new Color(0f, 0f, 1f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color Grey = new Color(0.5f, 0.5f, 0.5f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color Magenta = new Color(1f, 0f, 1f, 1f);
		[ZeroFormatter.IgnoreFormat]
		public static Color None = new Color(float.NaN, float.NaN, float.NaN, float.NaN);

		#endregion

		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public float r;
		[ZeroFormatter.Index(1)]
		public float g;
		[ZeroFormatter.Index(2)]
		public float b;
		[ZeroFormatter.Index(3)]
		public float a;

		#endregion

		#region Konstruktoren

		public Color(float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		public Color(byte r, byte g, byte b, byte a)
		{
			this.r = (float)((float)r / 255.0f);
			this.g = (float)((float)g / 255.0f);
			this.b = (float)((float)b / 255.0f);
			this.a = (float)((float)a / 255.0f);
		}

		public Color(byte[] byteArray, bool isArgb)
		{
			this.r = 0;
			this.g = 0;
			this.b = 0;
			this.a = 0;

			//Abbruch
			if (byteArray == null || byteArray.Length < 3)
				return;

			if (isArgb)
			{
				this.r = byteArray[3];
				this.g = byteArray[0];
				this.b = byteArray[1];
				this.a = byteArray[2];
			}
			else
			{
				if (byteArray.Length.Equals(3))
				{
					this.r = byteArray[0];
					this.g = byteArray[1];
					this.b = byteArray[2];
					this.a = 255;
				}
				else if (byteArray.Length.Equals(4))
				{
					this.r = byteArray[0];
					this.g = byteArray[1];
					this.b = byteArray[2];
					this.a = byteArray[3];
				}
			}

			this.r = (float)((float)this.r / 255.0f);
			this.g = (float)((float)this.g / 255.0f);
			this.b = (float)((float)this.b / 255.0f);
			this.a = (float)((float)this.a / 255.0f);
		}

		/// <summary>
		/// Farbe mit Hex-String festlegen
		/// </summary>
		/// <param name="strHex">#RRGGBB</param>
		public Color(string strHex)
		{
			this.r = 0;
			this.g = 0;
			this.b = 0;
			this.a = 0;

			if (string.IsNullOrEmpty(strHex) ||
				strHex.Length < 6)
				return;

			if (strHex[0].Equals('#'))
			{
				string colorcode = strHex.TrimStart('#');

				this.r = (float)int.Parse(colorcode.Substring(0, 2), NumberStyles.HexNumber) / 255.0f;
				this.g = (float)int.Parse(colorcode.Substring(2, 2), NumberStyles.HexNumber) / 255.0f;
				this.b = (float)int.Parse(colorcode.Substring(4, 2), NumberStyles.HexNumber) / 255.0f;
				this.a = 1.0f;
			}
		}

		#endregion

		#region Methoden

		public bool IsNone()
		{
			if (this.r.Equals(float.NaN) ||
				this.g.Equals(float.NaN) ||
				this.b.Equals(float.NaN) ||
				this.a.Equals(float.NaN))
				return true;
			return false;
		}

		public override string ToString()
		{
			return base.ToString();
		}

		#endregion
	}
}
