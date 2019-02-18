using Terraria.ModLoader;

namespace ORM.Items.Placables.Blocks
{
    public class CobbleWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;
            item.useStyle = 1;
            item.consumable = true;
            item.createWall = mod.WallType("CobbleWallTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cobblestone", 5);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}