using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Userinputbot1.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        string Name;
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> username)
        {
            var response = await username;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetName,
                prompt: "Please enter your name."
            );
        }
        public virtual async Task ResumeGetName(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            Name = response;
            await context.PostAsync("Text entered by you : " + Name);
            context.Done(this);
        }
    }
}