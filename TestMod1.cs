using Terraria.ModLoader;

namespace TestMod1
{
	class TestMod1 : Mod
	{
		public TestMod1()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
