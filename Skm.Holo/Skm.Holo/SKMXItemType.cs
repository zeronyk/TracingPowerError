namespace Skm.Holo
{
	[System.Flags()]
	public enum SKMXItemType
	{
		Unknown = 1,
		Root = 2,
		DirectorySmobs = 4,
		DirectoryTextures = 8,
		DirectoryVideos = 16,
		DirectoryImages = 32,
		DirectoryAudio = 64,
		DirectoryDocuments = 128,
		Smob = 256,
		Video = 512,
		Image = 1024,
		Audio = 2048,
		Document = 4096,
		Directory = 8192
	}
}