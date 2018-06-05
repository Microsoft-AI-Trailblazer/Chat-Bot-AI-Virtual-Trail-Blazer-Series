using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Userinputbot2.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        private const string CSharp = "C#";
        private const string Nodejs = "Node.js";
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            PromptDialog.Choice(context, this.AfterMenuSelection, new List<string>() { CSharp, Nodejs }, "What is your choice of platform ?");
        }

        private async Task AfterMenuSelection(IDialogContext context, IAwaitable<string> result)
        {
            var optionSelected = await result;
            switch (optionSelected)
            {
                case CSharp:
                    await context.PostAsync("Choice selected by you : C#");
                    break;
                case Nodejs:
                    await context.PostAsync("Choice selected by you : Node.js");
                    break;


            }

        }
    }
}