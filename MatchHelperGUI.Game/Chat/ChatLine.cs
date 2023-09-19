using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osuTK;

namespace MatchHelperGUI.Game.Chat;

public partial class ChatLine : CompositeDrawable
{
    private Message message;

    public ChatLine(Message message)
    {
        this.message = message;
        AutoSizeAxes = Axes.Both;

        InternalChild = new FillFlowContainer
        {
            AutoSizeAxes = Axes.Both,
            Direction = FillDirection.Horizontal,
            Spacing = new Vector2(5, 0),
            Children = new Drawable[]
            {
                new SpriteText
                {
                    Text = message.Date.ToString("HH:mm:ss"),
                    Font = OsuFont.Default.With(size: 15, weight: "SemiBold"),
                    Margin = new MarginPadding { Top = 5, Right = 5 }
                },
                new ChatUsername(message.Username)
                {
                    Width = 120,
                },
                new SpriteText
                {
                    Text = message.Text,
                    Margin = new MarginPadding { Top = 5 },
                    Font = OsuFont.Default,
                    Width = 500,
                    AllowMultiline = true,
                }
            }
        };
    }
}
