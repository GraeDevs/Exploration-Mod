using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ORM.Projectiles
{
    public class Bulb2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bulb2");
        }

        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 3;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            projectile.timeLeft = 150;
        }

        public override void AI()
        {
            int num;
            for (int num368 = 0; num368 < 4; num368 = num + 1)
            {
                float num369 = projectile.velocity.X / 2f * (float)num368;
                float num370 = projectile.velocity.Y / 2f * (float)num368;
                int num44 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 44, 0f, 0f, 0, default(Color), 1f);
                Main.dust[num44].position.X = projectile.Center.X - num369;
                Main.dust[num44].position.Y = projectile.Center.Y - num370;
                Main.dust[num44].noGravity = true;
                Dust dust3 = Main.dust[num44];
                dust3.velocity *= 0f;
                Main.dust[num44].scale = 0.8f;
                num = num368;
            }
        }
    }
}