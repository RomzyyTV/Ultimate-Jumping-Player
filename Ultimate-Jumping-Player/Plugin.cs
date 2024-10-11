using System;
using Exiled.API.Features;

namespace Ultimate_Jumping_Player;
public class Plugin : Plugin<Config>
{
    public override string Author => "RomzyyTV";
    public override string Name => "Ultimate-Jumping-Player";
    public override Version Version => new Version(1, 1, 0);
    public override Version RequiredExiledVersion { get; } = new(8, 12, 2);
    public static Plugin Singleton;
    public static EventHandlers Handlers;
    
    public override void OnEnabled()
    {
        Singleton = this;
        Handlers = new EventHandlers();
        
        Exiled.Events.Handlers.Player.Jumping += Handlers.OnPlayerJumping;
        base.OnEnabled();
    }
    
    public override void OnDisabled()
    {
        Singleton = null;
        Handlers = null;
        
        Exiled.Events.Handlers.Player.Jumping -= Handlers.OnPlayerJumping;
        base.OnDisabled();
    }
}