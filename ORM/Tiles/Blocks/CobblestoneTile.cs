using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ORM.Tiles.Blocks
{
    public class CobblestoneTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileLighted[Type] = false;
            dustType = 12;
            soundType = 21;
            soundStyle = 2;
            mineResist = 1f;
            minPick = 25;
            AddMapEntry(new Color(0, 0, 0));
            drop = mod.ItemType("Cobblestone");
        }
    }
}