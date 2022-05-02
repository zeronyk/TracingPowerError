namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public class Texture
	{
		public enum DataFormat
		{
			Unknown,//0
			Jpeg,//1
			Argb32,//2
			Tga,//3
			Png//4
		}

		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public virtual string DiffuseMapFileName { get; set; }
		[ZeroFormatter.IgnoreFormat]
		public byte[] DiffuseMapData { get; set; }
		public byte[] _DiffuseMapData() { return this.DiffuseMapData; }
		[ZeroFormatter.IgnoreFormat]
		public int DiffuseMapFormat { get; set; }
		public int _DiffuseMapFormat() { return this.DiffuseMapFormat; }
		[ZeroFormatter.IgnoreFormat]
		public int Width { get; set; }
		public int _Width() { return this.Width; }
		[ZeroFormatter.IgnoreFormat]
		public int Height { get; set; }
		public int _Height() { return this.Height; }

		#endregion
	}
}