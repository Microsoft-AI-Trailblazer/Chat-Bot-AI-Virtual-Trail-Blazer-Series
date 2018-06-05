using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Waterfallbot.Dialogs
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
            var response = await activity;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetName,
                prompt: "Please enter your name."
            );


        }

        public virtual async Task ResumeGetName(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            name = response;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetCity,
                prompt: "Please enter city.",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }

        public virtual async Task ResumeGetCity(IDialogContext context, IAwaitable<string> UserCity)
        {
            string response = await UserCity;
            city = response; ;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetCompany,
                prompt: "Please enter company name.",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }
        public virtual async Task ResumeGetCompany(IDialogContext context, IAwaitable<string> UserCompany)
        {
            string response = await UserCompany;
            company = response;

            await context.PostAsync("Information entered by you:" +"\n\n"+ "Name : "+name +"\n"+ "City : "+city+"\n"+"Company : "+company);



            context.Done(this);
        }

       
        
    }
}