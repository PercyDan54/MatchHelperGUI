using System;
using System.Threading;
using System.Threading.Tasks;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.IO.Network;

namespace MatchHelperGUI.Game.Chat;

public partial class ChatReciever : Component
{
    private Task task;
    private CancellationToken cancellationToken;

    [Resolved]
    private ChatDisplay chatDisplay { get; set; }

    [BackgroundDependencyLoader]
    private void load()
    {
        cancellationToken = new CancellationToken();
        task = Task.Run(loop, cancellationToken);
    }

    private async void loop()
    {
        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var r = new JsonWebRequest<Message[]>("http://127.0.0.1:3333/api/query") { AllowInsecureRequests = true };
                r.Perform();

                if (r.Completed && chatDisplay != null)
                {
                    var msgs = r.ResponseObject;

                    foreach (var message in msgs)
                    {
                        chatDisplay.AddMessage(message);
                    }
                }

                await Task.Delay(500, cancellationToken);
            }
        }
        catch (Exception e)
        {
            task = Task.Run(loop, cancellationToken);
        }
    }

}
