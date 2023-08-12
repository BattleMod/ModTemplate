using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace ModTemplate;

[BepInPlugin("link.ryhn.battlemod.modtemplate", "Mod Template", "1.0.0.0")]
public class Plugin : BasePlugin
{
	public static Plugin Instance;

	public override void Load()
	{
		Instance = this;
		Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
	}
}