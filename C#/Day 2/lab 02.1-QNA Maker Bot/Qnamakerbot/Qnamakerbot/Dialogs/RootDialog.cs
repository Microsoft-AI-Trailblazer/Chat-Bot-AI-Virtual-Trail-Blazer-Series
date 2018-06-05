using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using QnAMakerDialog;

namespace Qnamakerbot.Dialogs
{
    [Serializable]
    [QnAMakerService("https://mcdonalds.azurewebsites.net/qnamaker","c12ad8aa-7ecd-4df4-8673-8d8a509f6742","a212c6fe-5142-497b-993f-dcb099ae7fa8")]
    public class RootDialog : QnAMakerDialog<object>
    {

    }
}