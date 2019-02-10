using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace ORM.Items.Placables.Blocks
{
    public class SewerPipe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Creaks slightly with movement.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("SewerPipeTile");
        }
    }
}
