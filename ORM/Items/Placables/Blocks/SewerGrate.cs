using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace ORM.Items.Placables.Blocks
{
	public class SewerGrate : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Sturdy, isn't it?");
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
			item.createTile = mod.TileType("SewerGrateTile");
		}
	}
}
