using System;

namespace Skm.Holo
{
	[ZeroFormatter.ZeroFormattable]
	public class Material
	{
		#region Eigenschaften

		[ZeroFormatter.Index(0)]
		public virtual Texture MainTexture { get; set; }
		[ZeroFormatter.Index(1)]
		public virtual Color Color { get; set; }
		[ZeroFormatter.Index(2)]
		public virtual string Id { get; set; }
		[ZeroFormatter.Index(3)]
		public virtual int ShaderId { get; set; }
		[ZeroFormatter.IgnoreFormat]
		public ShaderId Shader
		{
			get
			{
				return (ShaderId)this.ShaderId;
			}
		}
		[ZeroFormatter.Index(4)]
		public virtual float Shininess { get; set; }
		[ZeroFormatter.Index(5)]
		public virtual float Opacity { get; set; }

		#endregion

		#region Methoden

		public override bool Equals(object obj)
		{
			if (obj is Material)
			{
				if ((obj as Material).Id.Equals(this.Id))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static Material CreateMaterialByColor(Color color)
		{
			Material TempMat = new Material();

			TempMat.ShaderId = (int)Holo.ShaderId.ShadingColor;
			TempMat.MainTexture = null;
			TempMat.Color = color;
			TempMat.Id = "ColorMaterial " +
				Math.Round(color.r * 255.0f, 0).ToString() + "," +
				Math.Round(color.g * 255.0f, 0).ToString() + "," +
				Math.Round(color.b * 255.0f, 0).ToString() + "," +
				Math.Round(color.a * 255.0f, 0).ToString();

			return TempMat;
		}

		#endregion
	}
}