namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public struct Bounds
	{
		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public Vector3 Extents;

		[ZeroFormatter.Index(1)]
		public Vector3 Center;

		[ZeroFormatter.IgnoreFormat]
		public Vector3 Size
		{
			get
			{
				return this.Extents * 2;
			}
			set
			{
				this.Extents = value * 0.5f;
			}
		}
		public Vector3 _Size() { return this.Size; }

		[ZeroFormatter.IgnoreFormat]
		public Vector3 Min
		{
			get
			{
				return this.Center - this.Extents;
			}
			set
			{
				this.SetMinMax(value, this.Max);
			}
		}
		public Vector3 _Min() { return this.Min; }

		[ZeroFormatter.IgnoreFormat]
		public Vector3 Max
		{
			get
			{
				return this.Center + this.Extents;
			}
			set
			{
				this.SetMinMax(this.Min, value);
			}
		}
		public Vector3 _Max() { return this.Max; }

		#endregion

		#region Konstruktoren

		public Bounds(Vector3 centerPoint, Vector3 size)
		{
			this.Center = centerPoint;
			this.Extents = size * 0.5f;
		}

		#endregion

		#region Methoden

		public void SetMinMax(Vector3 minVector, Vector3 maxVector)
		{
			if (minVector == null || maxVector == null)
				return;

			this.Extents = (maxVector - minVector) * 0.5f;
			this.Center = minVector + this.Extents;
		}

		#endregion
	}
}