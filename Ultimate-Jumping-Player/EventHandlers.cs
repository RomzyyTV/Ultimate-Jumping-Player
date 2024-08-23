using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;

namespace Ultimate_Jumping_Player;
public class EventHandlers : Plugin<Config>
{
    
    public override string Author => "RomzyyTV";
    public override string Name => "Ultimate-Jumping-Player";
    public override Version Version => new Version(1, 0, 0);
    public override Version RequiredExiledVersion { get; } = new(8, 11, 0);
    
    
    public override void OnEnabled()
    {
        Exiled.Events.Handlers.Player.Jumping += OnPlayerJumping;
        base.OnEnabled();
    }
    
    public override void OnDisabled()
    {
        Exiled.Events.Handlers.Player.Jumping -= OnPlayerJumping;
        base.OnDisabled();
    }
    
    private void OnPlayerJumping(JumpingEventArgs ev)
    {
        if (!ev.Player.IsScp)
            ev.Player.Stamina -= Config.RemoveStamina;
            ev.Player.ShowHint(Config.MessageHint, Config.DurationHint);
    }
}