using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MatchHelperGUI.Game.Chat;

[JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
public class Message
{
    public Message(string text, string username)
    {
        Text = text;
        Username = username;
    }

    public string Text { get; set; }
    public string Username { get; set; }
    public DateTime Date { get; set; }
}
