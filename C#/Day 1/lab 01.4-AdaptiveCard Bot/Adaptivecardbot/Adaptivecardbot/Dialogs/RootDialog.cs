using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdaptiveCards;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Adaptivecardbot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;

            var reply = context.MakeMessage();

            if (message.Text != null && message.Text.Equals("hi"))
            {
                var attachment = CreateAdapativecard();
                reply.Attachments.Add(attachment);
                await context.PostAsync(reply);
                context.Wait(this.MessageReceivedAsync);
            }
            if (message.Value != null)
            {


                // Got an Action Submit
                dynamic value = message.Value;
                string submitType = value.Type.ToString();
                switch (submitType)
                {
                    case "Entry":
                        var attachment1 = FormAdapativecard(message);
                        reply.Attachments.Add(attachment1);
                        await context.PostAsync(reply);
                        context.Wait(this.MessageReceivedAsync);
                        return;
                    case "Thanks":
                        await context.PostAsync("Thank you for your response.");
                        context.Wait(this.MessageReceivedAsync);
                        return;
                }

            }

        }
        public Attachment CreateAdapativecard()
        {
            var card = new AdaptiveCard()
            {
                Body = new List<CardElement>()
                {

                new TextBlock() { Text = "Form",Weight = TextWeight.Bolder },
                new TextBlock() { Text = "Please fill the following information below.",Weight = TextWeight.Normal },
                new TextInput()
                {
                Id = "Name",
                Style = TextInputStyle.Text
                },


                new TextInput()
                {
                Id = "City",
                Style = TextInputStyle.Text
                },

                new TextInput()
                {
                Id = "Company",
                Style = TextInputStyle.Text
                },

            },

                Actions = new List<ActionBase>()
            {
                new SubmitAction()
                {
                Title = "Submit",
                DataJson = "{ \"Type\": \"Entry\" }"

                }
            }
            };
            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };
            return attachment;

        }

        public Attachment FormAdapativecard(IMessageActivity message)
        {
            dynamic val = message.Value;
            string Name = val.Name.ToString();
            string City = val.City.ToString();
            string Company = val.Company.ToString();
            var card = new AdaptiveCard()

            {


                Body = new List<CardElement>()
                {
                    new Container()
                    {


                        Items = new List<CardElement>()
                        {
                            new TextBlock()
                            {
                            Text = "Summary",
                            Weight = TextWeight.Bolder,
                            Size = TextSize.Medium
                            },
                            new TextBlock()
                            {
                            Text = "Please confirm the following information entered by you.",
                            Weight = TextWeight.Normal,
                            },

                            new ColumnSet()
                            {
                            Columns = new List<Column>()
                            {

                            new Column()
                            {
                            Items = new List<CardElement>()
                            {
                                new FactSet()
                                {
                                    Facts = new List<AdaptiveCards.Fact>()
                                    {
                                        new AdaptiveCards.Fact()
                                        {
                                            Title = "Name:",
                                            Value =Name
                                        },
                                        new AdaptiveCards.Fact()
                                        {
                                            Title = "City:",
                                            Value = City
                                        },
                                        new AdaptiveCards.Fact()
                                        {
                                            Title = "Company:",
                                            Value = Company
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    },
                Actions = new List<ActionBase>()
                {
                    new SubmitAction()
                    {
                        Title = "Confirm",
                        DataJson = "{ \"Type\": \"Thanks\" }"

                    }
                }
            };
            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = card
            };
            return attachment;
        }


    }
}