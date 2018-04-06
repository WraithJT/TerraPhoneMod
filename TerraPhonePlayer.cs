using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;
using Terraria.UI;

namespace TerraPhoneMod
{
    class TerraPhonePlayer : ModPlayer
    {
        public static SpriteBatch spriteBatch;
        //public static GraphicsDeviceManager graphics;

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (TerraPhoneMod.TerraPhoneHotKey.JustPressed)
            {
                //graphics = new GraphicsDeviceManager(base.GraphicsDeviceManager);
                //spriteBatch = new SpriteBatch(Main.instance.GraphicsDevice);
                Main.NewText("TEST MESSAGE", 255, 240, 0, false);
                //ChestUI.Draw(spriteBatch);
                Main.player[Main.myPlayer].chest = -2;
                //Main.player[myPlayer].chest = -2;
                Main.player[Main.myPlayer].talkNPC = -1;
                //Main.npcChatText = "";
                //VendingMachine.chooseTalkingNPC(vm);
                //Main.recBigList = false;
                Main.playerInventory = true;
                Main.npcShop = 0;
                //Main.InGuideCraftMenu = true;
                //Main.InReforgeMenu = false;
            }
        }
    }
}
