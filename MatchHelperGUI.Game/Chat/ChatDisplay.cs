using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace MatchHelperGUI.Game.Chat;

public partial class ChatDisplay : CompositeDrawable
{
    private FillFlowContainer container;

    [BackgroundDependencyLoader]
    private void load()
    {
        InternalChild = new Container
        {
            RelativeSizeAxes = Axes.Both,
            Children = new Drawable[]
            {
                new BasicScrollContainer
                {
                    RelativeSizeAxes = Axes.Both,
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = Colour4.DarkSalmon.Darken(0.7f)
                        },
                        container = new FillFlowContainer
                        {
                            AutoSizeAxes = Axes.Both,
                            Direction = FillDirection.Vertical,
                            Spacing = new Vector2(0, 15)
                        },
                    }
                },
                new BasicTextBox
                {
                    Anchor = Anchor.BottomCentre,
                    Origin = Anchor.BottomCentre,
                    RelativeSizeAxes = Axes.Both,
                    Size = new Vector2(1, 0.1f)
                }
            }
        };
    }

    public void AddMessage(Message message)
    {
        container.Add(new ChatLine(message));
    }
}
