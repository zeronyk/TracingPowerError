namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Matrix4x4
	{
		[ZeroFormatter.IgnoreFormat]
		public static Matrix4x4 Zero = new Matrix4x4
			(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

		[ZeroFormatter.IgnoreFormat]
		public static Matrix4x4 NaN = new Matrix4x4
			(float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN,
			float.NaN, float.NaN, float.NaN, float.NaN);

		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public float m00;
		[ZeroFormatter.Index(1)]
		public float m10;
		[ZeroFormatter.Index(2)]
		public float m20;
		[ZeroFormatter.Index(3)]
		public float m30;
		[ZeroFormatter.Index(4)]
		public float m01;
		[ZeroFormatter.Index(5)]
		public float m11;
		[ZeroFormatter.Index(6)]
		public float m21;
		[ZeroFormatter.Index(7)]
		public float m31;
		[ZeroFormatter.Index(8)]
		public float m02;
		[ZeroFormatter.Index(9)]
		public float m12;
		[ZeroFormatter.Index(10)]
		public float m22;
		[ZeroFormatter.Index(11)]
		public float m32;
		[ZeroFormatter.Index(12)]
		public float m03;
		[ZeroFormatter.Index(13)]
		public float m13;
		[ZeroFormatter.Index(14)]
		public float m23;
		[ZeroFormatter.Index(15)]
		public float m33;

		#endregion

		#region Konstruktor

		//public Matrix4x4()
		//{
		//}

		public Matrix4x4(float m00, float m10, float m20, float m30,
							  float m01, float m11, float m21, float m31,
							  float m02, float m12, float m22, float m32,
							  float m03, float m13, float m23, float m33)
		{
			this.m00 = m00;
			this.m10 = m10;
			this.m20 = m20;
			this.m30 = m30;
			this.m01 = m01;
			this.m11 = m11;
			this.m21 = m21;
			this.m31 = m31;
			this.m02 = m02;
			this.m12 = m12;
			this.m22 = m22;
			this.m32 = m32;
			this.m03 = m03;
			this.m13 = m13;
			this.m23 = m23;
			this.m33 = m33;
		}

		public Matrix4x4(ref Matrix4x4 matrix)
		{
			this.m00 = matrix.m00;
			this.m10 = matrix.m10;
			this.m20 = matrix.m20;
			this.m30 = matrix.m30;
			this.m01 = matrix.m01;
			this.m11 = matrix.m11;
			this.m21 = matrix.m21;
			this.m31 = matrix.m31;
			this.m02 = matrix.m02;
			this.m12 = matrix.m12;
			this.m22 = matrix.m22;
			this.m32 = matrix.m32;
			this.m03 = matrix.m03;
			this.m13 = matrix.m13;
			this.m23 = matrix.m23;
			this.m33 = matrix.m33;
		}

		#endregion
	}
}