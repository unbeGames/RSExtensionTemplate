using UnbeGames.API;
using UnbeGames.Support;

namespace Extension {
  public class MyExtension : BaseExtension {
    public MyExtension() {
      Log.Info($"Extention initialized");
    }    

    public override void OnStart() {
      Log.Info($"Game systems fully initialized.");
    }

    public override void OnEnable() {
      Log.Info($"Extention was enabled");
    }

    public override void OnDisable() {
      Log.Info($"Extention was disabled");
    }

    public override void OnGameLoad() {
      Log.Info($"Game was loaded");
    }

    public override void OnGameShutdown() {
      Log.Info($"Game was unloaded");
    }
  }
}
