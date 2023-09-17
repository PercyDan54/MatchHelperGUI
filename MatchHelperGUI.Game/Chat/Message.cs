using System;

namespace MatchHelperGUI.Game.Chat;

public class Message
{
    public Message(string text, string username)
    {
        Text = text;
        Username = username;
    }

    public string Text { get; set; }
    public string Username { get; set; }
    public string Color { get; set; }
    public DateTime Date { get; set; }
}
