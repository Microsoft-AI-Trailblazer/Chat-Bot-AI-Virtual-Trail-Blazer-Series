using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Cortanabot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        string name;
        string city;
        string company;

        
        public async Task StartAsync(IDialogContext context)
        {
            
            context.Wait(MessageReceivedAsync);
        }
        
        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> activity)
        {

            PromptDialog.Text(context,ResumeName,
               prompt: "Please enter your name.");
            
      }

        private async Task ResumeName(IDialogContext context, IAwaitable<string> username)
        {
              name = await username;

            PromptDialog.Text(context, Resumecity,
             prompt: "Please enter city.");
        }

        private async Task Resumecity(IDialogContext context, IAwaitable<string> usercity)
        {
            city = await usercity;

            PromptDialog.Text(context, Resumecompany,
             prompt: "Please enter company name.");

        }
        private async Task Resumecompany(IDialogContext context, IAwaitable<string> usercompany)
        {
           company = await usercompany;
           
            await context.PostAsync("Information entered by you:" + "\n\n" + "Name : " + name + "\n" + "City : " + city + "\n" + "Company : " + company);

            context.Done(this);
        }
    }
}