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
        [Cached]
        private ChatDisplay chat { get; set; } = new ChatDisplay
        {
            RelativeSizeAxes = Axes.Both,
        };

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
                    infoText = new SpriteText { Text = "未连接", Font = OsuFont.Default },
                    new ChatReciever(),
                    new GridContainer
                    {
                        RelativeSizeAxes = Axes.Both,
                        ColumnDimensions = new[] { new Dimension(GridSizeMode.Relative, 0.8f) },
                        Content = new[]
                        {
                            new Drawable[]
                            {
                                chat,
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
            chat.AddMessage(new Message("铃兰小姐每早七点按时起床叠被子刷牙晨读十分钟诗歌选集后前往医疗部门认真学习源石技艺的使用并积极帮助其他同龄人感染者处理情绪对每一位参与工作的医疗干员都诚恳慰问中午一定要小睡一个小时睡醒之后一定会喝一杯芝士巧克力就算有干员私下塞给糖果和小礼物她也会礼貌拒绝每当遇到奇怪的陌生人就会怯生生地站在干员的身后低头向前走下午会认真旁听会议或者华法琳的医疗干员讲座同时会细心地打扫会议现场最后一个关灯离开晚上基本躲在房间里看书累了的话会主动提出帮助后勤干员做一些杂活稍微夸奖她两句就会害羞晚上十点之前一定会上床睡觉偶尔会和泡普卡和巫恋小姐待在一起请记住铃兰小姐就是我们的光", "PercyDan"));
            chat.AddMessage(new Message("1aaaaaaaaaaaaaaaaaaa", "PercyDan"));
        }
    }
}
