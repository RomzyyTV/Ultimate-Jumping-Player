using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Usables;

namespace Ultimate_Jumping_Player;
public class EventHandlers
{
    public void OnPlayerJumping(JumpingEventArgs ev)
    {
        if (ev.Player.GetEffect(EffectType.Scp207).IsEnabled) return;
        if (!ev.Player.IsScp)
        {
            ev.Player.Stamina -= Plugin.Singleton.Config.RemoveStamina;
            ev.Player.ShowHint(Plugin.Singleton.Config.MessageHint, Plugin.Singleton.Config.DurationHint);
        }
    }
}