using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osuTK.Graphics;

namespace MatchHelperGUI.Game.Chat;

public partial class ChatUsername : CompositeDrawable
{
    private readonly Box colouredDrawable;
    private readonly SpriteText spriteText;
    private Color4 accentColor;

    public Color4 AccentColor
    {
        get => accentColor;
        set
        {
            accentColor = value;
            colouredDrawable.Colour = value;
        }
    }

    public override float Width
    {
        get => base.Width;
        set
        {
            base.Width = spriteText.MaxWidth = value;
        }
    }

    public ChatUsername(string username)
    {
        AutoSizeAxes = Axes.Y;
        Masking = true;
        CornerRadius = 4;

        spriteText = new SpriteText
        {
            Text = username + ": ",
            Truncate = true,
            EllipsisString = "...: ",
            Font = OsuFont.Default
        };
        InternalChild = new Container
        {
            AutoSizeAxes = Axes.Both,
            Masking = true,
            CornerRadius = 4,
            Child = new Container
            {
                AutoSizeAxes = Axes.Both,
                Masking = true,
                CornerRadius = 4,
                Children = new Drawable[]
                {
                    colouredDrawable = new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                    },
                    new Container
                    {
                        Margin = new MarginPadding(5),
                        AutoSizeAxes = Axes.Both,
                        Child = spriteText,
                    }
                }
            }
        };
    }

    protected override void LoadComplete()
    {
        base.LoadComplete();
        colouredDrawable.Colour = AccentColor;
    }
}
