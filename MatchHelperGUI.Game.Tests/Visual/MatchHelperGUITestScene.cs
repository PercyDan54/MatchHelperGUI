using osu.Framework.Testing;

namespace MatchHelperGUI.Game.Tests.Visual
{
    public partial class MatchHelperGUITestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new MatchHelperGUITestSceneTestRunner();

        private partial class MatchHelperGUITestSceneTestRunner : MatchHelperGUIGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
