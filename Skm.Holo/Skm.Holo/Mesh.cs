using System;
using System.Collections.Generic;

namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public class Mesh
	{
		public const long MAX_ELEMENTS = 60000;

		private enum DumpFormat
		{
			VVVNNN,
			VVVNNNCCC,
			VVVNNNTTT,
			VVVNNNTTTCCC,
			None
		}

		#region Felder

		private List<object> _TriangleDump = null;
		private DumpFormat _TriangleDumpFormat = DumpFormat.None;

		#endregion

		#region Eigenschaften

		//Index  0 belegt durch alte Variante
		[ZeroFormatter.Index(1)]
		public virtual int SubMeshCount { get; set; }
		[ZeroFormatter.Index(2)]
		public virtual Bounds Bounds { get; set; }
		[ZeroFormatter.Index(3)]
		public virtual Vector3[] Normals { get; set; }
		[ZeroFormatter.Index(4)]
		public virtual Vector4[] Tangents { get; set; }
		[ZeroFormatter.Index(5)]
		public virtual Vector2[] Uv { get; set; }
		[ZeroFormatter.Index(6)]
		public virtual Vector2[] Uv2 { get; set; }
		[ZeroFormatter.Index(7)]
		public virtual Vector2[] Uv3 { get; set; }
		[ZeroFormatter.Index(8)]
		public virtual Vector2[] Uv4 { get; set; }
		[ZeroFormatter.Index(9)]
		public virtual Color[] Colors { get; set; }
		[ZeroFormatter.Index(10)]
		public virtual Vector3[] Vertices { get; set; }
		[ZeroFormatter.Index(11)]
		public virtual Color[] Colors32 { get; set; }
		[ZeroFormatter.Index(12)]
		public virtual int[] Triangles { get; set; }
		[ZeroFormatter.Index(13)]
		public virtual string MaterialId { get; set; }
		/// <summary>
		/// Nicht mehr verwenden!
		/// </summary>
		[ZeroFormatter.Index(14)]
		public virtual int ShaderId { get; set; }

		[ZeroFormatter.IgnoreFormat()]
		public Material Material { get; set; }
		[ZeroFormatter.IgnoreFormat]
		public ShaderId Shader
		{
			get
			{
				return (ShaderId)this.ShaderId;
			}
		}

		#endregion

		#region Methoden

		public void DumpTriangle(Vector3 v1, Vector3 v2, Vector3 v3,
			Vector3 n1, Vector3 n2, Vector3 n3)
		{
			if (this._TriangleDump == null)
			{
				this._TriangleDump = new List<object>();
				this._TriangleDumpFormat = DumpFormat.VVVNNN;
			}

			this._TriangleDump.Add(v1);
			this._TriangleDump.Add(v2);
			this._TriangleDump.Add(v3);

			this._TriangleDump.Add(n1);
			this._TriangleDump.Add(n2);
			this._TriangleDump.Add(n3);
		}

		public void DumpTriangle(Vector3 v1, Vector3 v2, Vector3 v3,
			Vector3 n1, Vector3 n2, Vector3 n3, Color c1, Color c2, Color c3)
		{
			if (this._TriangleDump == null)
			{
				this._TriangleDump = new List<object>();
				this._TriangleDumpFormat = DumpFormat.VVVNNNCCC;
			}

			this._TriangleDump.Add(v1);
			this._TriangleDump.Add(v2);
			this._TriangleDump.Add(v3);

			this._TriangleDump.Add(n1);
			this._TriangleDump.Add(n2);
			this._TriangleDump.Add(n3);

			this._TriangleDump.Add(c1);
			this._TriangleDump.Add(c2);
			this._TriangleDump.Add(c3);
		}

		public void DumpTriangle(Vector3 v1, Vector3 v2, Vector3 v3,
			Vector3 n1, Vector3 n2, Vector3 n3, Vector2 t1, Vector2 t2, Vector2 t3)
		{
			if (this._TriangleDump == null)
			{
				this._TriangleDump = new List<object>();
				this._TriangleDumpFormat = DumpFormat.VVVNNNTTT;
			}

			this._TriangleDump.Add(v1);
			this._TriangleDump.Add(v2);
			this._TriangleDump.Add(v3);

			this._TriangleDump.Add(n1);
			this._TriangleDump.Add(n2);
			this._TriangleDump.Add(n3);

			this._TriangleDump.Add(t1);
			this._TriangleDump.Add(t2);
			this._TriangleDump.Add(t3);
		}
		public void DumpTriangle(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 n1, Vector3 n2, Vector3 n3,
			Vector2 t1, Vector2 t2, Vector2 t3, Color c1, Color c2, Color c3)
		{
			if (this._TriangleDump == null)
			{
				this._TriangleDump = new List<object>();
				this._TriangleDumpFormat = DumpFormat.VVVNNNTTTCCC;
			}

			this._TriangleDump.Add(v1);
			this._TriangleDump.Add(v2);
			this._TriangleDump.Add(v3);

			this._TriangleDump.Add(n1);
			this._TriangleDump.Add(n2);
			this._TriangleDump.Add(n3);

			this._TriangleDump.Add(t1);
			this._TriangleDump.Add(t2);
			this._TriangleDump.Add(t3);

			this._TriangleDump.Add(c1);
			this._TriangleDump.Add(c2);
			this._TriangleDump.Add(c3);
		}

		#endregion
	}
}