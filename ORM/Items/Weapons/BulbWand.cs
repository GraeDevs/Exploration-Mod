using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ORM.Items.Weapons
{
	public class BulbWand : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("");
			Item.staff[item.type] = true; 
		}

		public override void SetDefaults() {
			item.damage = 34;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Bulb1");
			item.shootSpeed = 16f;
		}
	}
}