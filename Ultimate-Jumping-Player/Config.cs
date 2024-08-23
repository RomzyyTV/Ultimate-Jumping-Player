using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Ultimate_Jumping_Player;
public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
	
    public bool Debug { get; set; }
    
    [Description("Remove stamina for player jump please put f at the end")]
    public float RemoveStamina { get; set; } = 0.15f;
    
    [Description("Hint for player jump")]
    public string MessageHint { get; set; } = "<b><size=22>please don't jump</size></b>";

    [Description("Duration Hint")] 
    public float DurationHint { get; set; } = 5f;
}