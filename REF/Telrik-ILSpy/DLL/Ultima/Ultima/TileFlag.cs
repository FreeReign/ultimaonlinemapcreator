using System;

namespace Ultima
{
	[Flags]
	public enum TileFlag
	{
		StairRight = -2147483648,
		None = 0,
		Background = 1,
		Weapon = 2,
		Transparent = 4,
		Translucent = 8,
		Wall = 16,
		Damaging = 32,
		Impassable = 64,
		Wet = 128,
		Unknown1 = 256,
		Surface = 512,
		Bridge = 1024,
		Generic = 2048,
		Window = 4096,
		NoShoot = 8192,
		ArticleA = 16384,
		ArticleAn = 32768,
		Internal = 65536,
		Foliage = 131072,
		PartialHue = 262144,
		Unknown2 = 524288,
		Map = 1048576,
		Container = 2097152,
		Wearable = 4194304,
		LightSource = 8388608,
		Animation = 16777216,
		NoDiagonal = 33554432,
		Unknown3 = 67108864,
		Armor = 134217728,
		Roof = 268435456,
		Door = 536870912,
		StairBack = 1073741824
	}
}