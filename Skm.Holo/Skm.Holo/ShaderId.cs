namespace Skm.Holo
{
	public enum ShaderId
	{
		None,//0
		ShadingColor,//1			Gouraud/Phong mit Farbe
		ShadingTexture,//2		Gouraud/Phong mit Textur
		ShadingVertexColor,//3	Gouraud/Phong mit Vertexfarben
		UnlitColor,//4				Farbe unbeleuchtet
		UnlitTexture,//5			Textur unbeleuchtet
		UnlitVertexColor,//6		Vertexfarben unbeleuchtet
		Wireframe//7				Drahtgitter
	}
}