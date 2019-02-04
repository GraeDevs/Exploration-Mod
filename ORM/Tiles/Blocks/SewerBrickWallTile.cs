using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ORM.Tiles.Blocks
{
	public class SewerBrickWallTile : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("SewerBrickWall");
			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}