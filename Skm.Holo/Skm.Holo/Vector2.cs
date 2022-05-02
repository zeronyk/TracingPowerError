namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Vector2
	{
		#region Eigenschaten

		[ZeroFormatter.Index(0)]
		public float x;
		[ZeroFormatter.Index(1)]
		public float y;

		#endregion

		#region Konstruktoren

		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		#endregion

		#region Operatoren

		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}

		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}

		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}

		public static Vector2 operator *(Vector2 a, float d)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		public static Vector2 operator *(float d, Vector2 a)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		public static Vector2 operator /(Vector2 a, float d)
		{
			return new Vector2(a.x / d, a.y / d);
		}

		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return (SqrMagnitude(lhs - rhs)) < 9.99999943962493E-11;
		}

		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return !(lhs == rhs);
		}

		public static implicit operator Vector2(Vector3 v)
		{
			return new Vector2(v.x, v.y);
		}

		public static implicit operator Vector3(Vector2 v)
		{
			return new Vector3(v.x, v.y, 0.0f);
		}

		#endregion

		#region Methoden

		public static float SqrMagnitude(Vector2 a)
		{
			if (a == null)
				return 0;

			return (float)(a.x * a.x + a.y * a.y);
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#endregion
	}
}