using MatchHelperGUI.Game.Chat;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;

namespace MatchHelperGUI.Game
{
    public partial class MainScreen : Screen
    {
        private ChatDisplay chat;
        private SpriteText infoText;

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChild = new FillFlowContainer
            {
                RelativeSizeAxes = Axes.Both,
                Direction = FillDirection.Vertical,
                Margin = new MarginPadding(10),
                Spacing = new Vector2(0, 5),
                Children = new Drawable[]
                {
                    infoText = new SpriteText { Text = "未连接", Font = OsuFont.GetFont().With(size: 20) },
                    new GridContainer
                    {
                        RelativeSizeAxes = Axes.Both,
                        ColumnDimensions = new[] { new Dimension(GridSizeMode.Relative, 0.6f) },
                        Content = new[]
                        {
                            new Drawable[]
                            {
                                chat = new ChatDisplay
                                {
                                    RelativeSizeAxes = Axes.Both,
                                },
                                new Box
                                {
                                    RelativeSizeAxes = Axes.Both,
                                    Colour = Colour4.Aqua
                                }
                            }
                        }
                    }
                }
            };
            chat.AddMessage(new Message("PercyDan222222222", "PercyDan"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
            chat.AddMessage(new Message("PercyDan22222222", "卧槽"));
        }
    }
}
