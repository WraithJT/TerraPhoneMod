using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraPhoneMod.Items
{
	public class TerraPhonev1 : ModItem
	{
        public override string Texture
        {
            get { return "Terraria/Item_" + ItemID.CellPhone; }
        }

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Phone");
			Tooltip.SetDefault("Access to every facet of your life, at your fingertips. And it only costs a month's salary and access to all of your data.\r\nAllows you to return home at will.");
		}


        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CellPhone);
            item.color = Color.SlateGray;
            item.rare = 8;
        }

        public override void UseStyle(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 5;
            }
            else
            {
                item.useStyle = 4;
                if (Main.rand.NextBool(2))
                {
                    Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.1f);
                }
                if (player.itemTime == 0)
                {
                    player.itemTime = (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item));
                }
                else if (player.itemTime == (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item)) / 2)
                {
                    for (int d = 0; d < 70; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 15, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default(Color), 1.5f);
                    }
                    player.grappling[0] = -1;
                    player.grapCount = 0;
                    for (int p = 0; p < 1000; p++)
                    {
                        if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI && Main.projectile[p].aiStyle == 7)
                        {
                            Main.projectile[p].Kill();
                        }
                    }
                    player.Spawn();
                    for (int d = 0; d < 70; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default(Color), 1.5f);
                    }
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            //recipe.AddIngredient(ItemID.CellPhone);
            //recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
