using System;
using System.Linq;

namespace Skm.Holo
{
	public static partial class DataAccess
	{
		public static void ReadHoloSmobFromStlFile()
		{
			// i really dont know why it breaks 
			Console.WriteLine("This one is not printed on the stdout");

			Mesh TempMesh = new Mesh();
			TempMesh.DumpTriangle(new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0));
			TempMesh.DumpTriangle(new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0));
		}
	}
}