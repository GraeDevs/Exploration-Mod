using Terraria.ModLoader;

namespace ORM.Items.Placables.Blocks
{
	public class SewerBrickWall : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("SewerBrickWallTile");
		}
	}
}