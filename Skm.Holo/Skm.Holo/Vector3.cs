using System;
using System.Globalization;

namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Vector3
	{
		[ZeroFormatter.IgnoreFormat]
		public static Vector3 Zero = new Vector3(0, 0, 0);
		[ZeroFormatter.IgnoreFormat]
		public static Vector3 IdentityX = new Vector3(1, 0, 0);
		[ZeroFormatter.IgnoreFormat]
		public static Vector3 IdentityY = new Vector3(0, 1, 0);
		[ZeroFormatter.IgnoreFormat]
		public static Vector3 IdentityZ = new Vector3(0, 0, 1);
		[ZeroFormatter.IgnoreFormat]
		public static Vector3 NaN = new Vector3(float.NaN, float.NaN, float.NaN);

		[ZeroFormatter.Index(0)]
		public float x;
		[ZeroFormatter.Index(1)]
		public float y;
		[ZeroFormatter.Index(2)]
		public float z;



		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public Vector3(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0.0f;
		}

		public Vector3(ref Vector3 vector)
		{
			this.x = vector.x;
			this.y = vector.y;
			this.z = vector.z;
		}

		public Vector3(string strVector)
		{
			this.x = float.NaN;
			this.y = float.NaN;
			this.z = float.NaN;

			if (string.IsNullOrEmpty(strVector))
				return;

			string[] tempSplit = null;

			//Splitten
			tempSplit = strVector.Split(new string[] { " " }, StringSplitOptions.None);

			if (tempSplit == null || tempSplit.Length != 3)
				return;

			//Parsen
			this.x = float.Parse(tempSplit[0], CultureInfo.InvariantCulture);
			this.y = float.Parse(tempSplit[1], CultureInfo.InvariantCulture);
			this.z = float.Parse(tempSplit[2], CultureInfo.InvariantCulture);

			tempSplit = null;
		}

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3 operator -(Vector3 a)
		{
			return new Vector3(-a.x, -a.y, -a.z);
		}

		public static Vector3 operator *(Vector3 a, float d)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		public static Vector3 operator *(float d, Vector3 a)
		{
			return new Vector3(a.x * d, a.y * d, a.z * d);
		}

		public static Vector3 operator /(Vector3 a, float d)
		{
			return new Vector3(a.x / d, a.y / d, a.z / d);
		}

		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return SqrMagnitude(lhs - rhs) < 9.99999943962493E-11;
		}

		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return !(lhs == rhs);
		}

		public static Vector3 operator *(Vector3 pt1, Vector3 pt2)
		{
			Vector3 retVec = new Vector3();

			retVec.x = pt1.y * pt2.z - pt1.z * pt2.y;
			retVec.y = pt1.z * pt2.x - pt1.x * pt2.z;
			retVec.z = pt1.x * pt2.y - pt1.y * pt2.x;

			return retVec;
		}

		public bool IsZero()
		{
			if (this.x == 0 && this.y == 0 && this.z == 0)
				return true;
			return false;
		}

		public bool IsNaN()
		{
			if (this.x == float.NaN &&
				this.y == float.NaN &&
				this.z == float.NaN)
				return true;
			return false;
		}

		public bool IsNormalized()
		{
			double tempLength = 0;

			try
			{
				tempLength = Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
			}
			catch
			{
				return false;
			}

			return (tempLength > 0.95 && tempLength < 1.05);
		}

		public void Negate()
		{
			this.x = -this.x;
			this.y = -this.y;
			this.z = -this.z;
		}

		/// <summary>
		/// Funktioniert nicht, da struct!
		/// </summary>
		public int Normalize()
		{
			int iRet = 0;
			float tempLength = SqrMagnitude(this);

			if (tempLength < 0.001)
			{
				iRet = 1;
			}
			else
			{
				this.x /= tempLength;
				this.y /= tempLength;
				this.z /= tempLength;
			}

			return iRet;
		}

		public Vector3 GetNormalized()
		{
			float tempLength = (float)Math.Sqrt((double)SqrMagnitude(this));
			if (tempLength < 0.001)
				return Vector3.NaN;
			else
				return new Vector3(this.x /= tempLength, this.y /= tempLength, this.z /= tempLength);
		}

		public void Transform(Matrix matrix)
		{
			//Rotationen
			float[] fTemp = { this.x, this.y, this.z };
			float fVal = 0f;

			for (int i1 = 0; i1 < 3; i1++)
				fVal += matrix[0, i1] * fTemp[i1];
			this.x = fVal;

			fVal = 0f;
			for (int i1 = 0; i1 < 3; i1++)
				fVal += matrix[1, i1] * fTemp[i1];
			this.y = fVal;

			fVal = 0f;
			for (int i1 = 0; i1 < 3; i1++)
				fVal += matrix[2, i1] * fTemp[i1];
			this.z = fVal;

			//Translation
			this.x += matrix[0, 3];
			this.y += matrix[1, 3];
			this.z += matrix[2, 3];
		}


		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "(" + this.x.ToString(CultureInfo.InvariantCulture) + " " +
				 this.y.ToString(CultureInfo.InvariantCulture) + " " +
				 this.z.ToString(CultureInfo.InvariantCulture) + ")";
		}

		public string ToString(string format, bool bShowXYZ = false)
		{
			if (bShowXYZ)
			{
				return string.Format("X={0} Y={1} Z={2}",
					(object)this.x.ToString(format),
					(object)this.y.ToString(format),
					(object)this.z.ToString(format));
			}
			else
			{
				return string.Format("({0}, {1}, {2})",
					(object)this.x.ToString(format),
					(object)this.y.ToString(format),
					(object)this.z.ToString(format));
			}
		}

		public string ToSerializationString()
		{
			return this.x.ToString(CultureInfo.InvariantCulture) + " " +
				 this.y.ToString(CultureInfo.InvariantCulture) + " " +
				 this.z.ToString(CultureInfo.InvariantCulture);
		}


		public static float SqrMagnitude(Vector3 a)
		{
			if (a == null)
				return 0;

			return (float)(a.x * a.x + a.y * a.y + a.z * a.z);
		}

		public static float SqrDistance(Vector3 p1, Vector3 p2)
		{
			return SqrMagnitude(p2 - p1);
		}

		public static float Distance(Vector3 p1, Vector3 p2)
		{
			if (p1 == null || p2 == null)
				return float.MaxValue;

			double TempX = p2.x - p1.x;
			double TempY = p2.y - p1.y;
			double TempZ = p2.z - p1.z;

			return (float)Math.Sqrt(TempX * TempX + TempY * TempY + TempZ * TempZ);
		}

		public static float DotProduct(Vector3 vec1, Vector3 vec2)
		{
			return vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;
		}
	}
}