using System;

namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Vector4
	{
		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public float x;
		[ZeroFormatter.Index(1)]
		public float y;
		[ZeroFormatter.Index(2)]
		public float z;
		[ZeroFormatter.Index(3)]
		public float w;

		#endregion

		#region Konstruktoren

		public Vector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public Vector4(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = 0.0f;
		}

		public Vector4(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0.0f;
			this.w = 0.0f;
		}

		#endregion

		#region Operatoren

		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		public static Vector4 operator -(Vector4 a)
		{
			return new Vector4(-a.x, -a.y, -a.z, -a.w);
		}

		public static Vector4 operator *(Vector4 a, float d)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		public static Vector4 operator *(float d, Vector4 a)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		public static Vector4 operator /(Vector4 a, float d)
		{
			return new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
		}

		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return SqrMagnitude(lhs - rhs) < 9.99999943962493E-11;
		}

		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return !(lhs == rhs);
		}

		public static implicit operator Vector4(Vector3 v)
		{
			return new Vector4(v.x, v.y, v.z, 0.0f);
		}

		public static implicit operator Vector3(Vector4 v)
		{
			return new Vector3(v.x, v.y, v.z);
		}

		public static implicit operator Vector4(Vector2 v)
		{
			return new Vector4(v.x, v.y, 0.0f, 0.0f);
		}

		public static implicit operator Vector2(Vector4 v)
		{
			return new Vector2(v.x, v.y);
		}

		#endregion

		#region Methoden

		public static float SqrMagnitude(Vector4 a)
		{
			if (a == null)
				return 0;

			return Dot(a, a);
		}

		public static float Dot(Vector4 a, Vector4 b)
		{
			if (a == null || b == null)
				return 0;

			return (float)(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w);
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
			return String.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", (object)this.x, (object)this.y, (object)this.z, (object)this.w);
		}

		public string ToString(string format)
		{
			return String.Format("({0}, {1}, {2}, {3})", (object)this.x.ToString(format), (object)this.y.ToString(format), (object)this.z.ToString(format), (object)this.w.ToString(format));
		}

		#endregion
	}
}