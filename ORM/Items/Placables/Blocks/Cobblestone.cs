using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ORM.Items.Placables.Blocks
{
    public class Cobblestone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobblestone");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.autoReuse = true;
            item.rare = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CobblestoneTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}