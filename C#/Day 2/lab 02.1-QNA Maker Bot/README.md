# QnaMaker Bot

In this lab you will build a simple question and answer bot based on FAQ URLs and Structured documents.


### Prerequisites
The following software environment is needed for running this bot :

```
1.Visual studio 2017.
2.Microsoft BotFramework Emulator.
3.Bot Application template.
```

### Collecting the keys

Over the course of this lab, we will collect various keys. It is recommended that you save all of them in a text file, so you can easily access them throughout the workshop.keys:
```
1.Bot Framework App ID.
2.Bot Framework App password.
3.knowledgeBaseId.
4.EndpointKey.
```

Note:Please refer following link to understand how to generate Bot Framework App ID and App password.  link :[Bot Registration](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).

### How to Train QnaMaker Service

1.To understand how to train QnA Maker services using FAQ URLs and structured documents, please refer following link:[Train QnA](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).

Note :Please refer sample QNADocument.doc in the following path "Chat-Bot-AI-Virtual-Trail-Blazer-Series\C#\Day 2\lab 02.1-QNA Maker Bot" to train QnA Maker Service with structured document or you can use the following sample link: "https://www.mcdonalds.com.sg/faq/mcdelivery-service/" for training QnA Maker Services. 



### Implementation

To check the implementation of this lab please refer to the following file in this path of folder Chat-Bot-AI-Virtual-Trail-Blazer-Series\C#\Day 2\lab 02.1-QNA Maker Bot\Qnamakerbot:

```
                             Qnamakerbot.sln
```

### Check implementation through following steps

1. Open Visual studio 2017.
2. In visual studio go to File->open->project then go to path of Qnamakerbot folder (Chat-Bot-AI-Virtual-Trail-Blazer-Series\C#\Day 2\lab 02.1-QNA Maker Bot\Qnamakerbot) and open Qnamakerbot.sln file.
3. Open RootDialog.cs file in Qnamakerbot.sln file  and paste BaseUri, knowledgeBaseId key and EndPointKey collected from the QnaMaker services.
4. Solution in visual studio will opened and  we have to provide Bot Framework App ID, Bot Framework App password in Web.config file.(note : If you are working on local then there is no need to specify Bot Framework App ID and Bot Framework App password ).

![web](https://user-images.githubusercontent.com/31923904/40702591-1b000c26-6400-11e8-89a3-6bbbc4aaa6b8.png)


5.Run the application by clicking the IIS Express (Google chrome) button, Visual Studio will build the application, deploy it to local host, and launch the web browser to display the application's host name as http://localhost:3979 in address bar of web browser. 

6.Start the Bot Framework Emulator and connect your bot and type http://localhost:3979/api/messages into the address bar.(This is the default end point that your bot listens to when hosted locally).Click on “Connect” button.(note : If you are working on local then no need to specify Microsoft App ID and Microsoft App Password ).

  
![botemulator](https://user-images.githubusercontent.com/31923904/40710991-b411a8fe-6417-11e8-96e9-7bad98d7a192.png)

  -The following screenshot shows the results of this chatbot running in the Bot Framework Channel Emulator.

![qnamakerbot](https://user-images.githubusercontent.com/31923904/40873117-01c54882-6678-11e8-8eed-84748afe29ff.png)
                                    





