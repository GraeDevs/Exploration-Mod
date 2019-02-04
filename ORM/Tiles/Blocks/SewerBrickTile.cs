using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ORM.Tiles.Blocks
{
	public class SewerBrickTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("SewerBrick");
			AddMapEntry(new Color(200, 200, 200));
            Main.tileBlockLight[Type] = true;
            Main.tileBrick[Type] = true;
        }

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}