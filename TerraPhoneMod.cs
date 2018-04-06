using Terraria;
using Terraria.ModLoader;

namespace TerraPhoneMod
{
	class TerraPhoneMod : Mod
	{
        public static ModHotKey TerraPhoneHotKey;

        public TerraPhoneMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void Load()
        {
            TerraPhoneHotKey = RegisterHotKey("Use TerraPhone", "P");
        }
    }
}
