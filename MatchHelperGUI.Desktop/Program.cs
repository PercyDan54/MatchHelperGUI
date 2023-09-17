using osu.Framework.Platform;
using osu.Framework;
using MatchHelperGUI.Game;

namespace MatchHelperGUI.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"MatchHelperGUI"))
            using (osu.Framework.Game game = new MatchHelperGUIGame())
                host.Run(game);
        }
    }
}
