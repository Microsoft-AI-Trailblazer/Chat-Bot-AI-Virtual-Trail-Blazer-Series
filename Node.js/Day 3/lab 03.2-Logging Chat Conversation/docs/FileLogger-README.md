# File logger

In this lab, you will build, a basic bot which always display back number of characters entered by user and logs converation between user and bot into .txt file.

### Prerequisites
The following software environment is needed for running this bot :

```
1.Node.js
2.Microsoft BotFramework Emulator.
3.SubLimeText Editor.
```

### Collecting the keys

Over the course of this lab, we will collect various keys. It is recommended that you save all of them in a text file, so you can easily access them throughout the workshop.keys:

```
-Bot Framework App ID.
-Bot Framework App password.
```

Note:Please refer following link to understand how to generate Bot Framework APP ID and App password.  link :[Bot Registration](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).

### Implementation

1.To understand how to intercept messages between user and bot please refer following link :[Intercept message](https://docs.microsoft.com/en-us/azure/bot-service/nodejs/bot-builder-nodejs-intercept-messages?view=azure-bot-service-3.0)

2.To check implementation of this lab please refer to the following file in this path Chat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\lab 03.2-Logging Chat Conversation\code\file logging:

```
                             file_logging.js
```

### Check implementation through following steps

1. Open file_logging.js file in SubLime Text Editor and provide Bot Framework App ID and Bot Framework App password in this section of code. (note : If you are working on local then there is no need to specify Bot Framework App ID and Bot Framework App password  ).

![adaptivecardbot_0](https://user-images.githubusercontent.com/31923904/39425015-f9250e9c-4c96-11e8-9636-f53ed8cc1a82.jpg)

2.Open command prompt (cmd) then set path to file logging folder then run file_logging.js file using command below:
```

                               node file_logging.js.
```
3.Start the Bot Framework Emulator and connect your bot and type http://localhost:3978/api/messages into the address bar.(This is the default end point that your bot listens to when hosted locally).Click on “Connect” button.(note : If you are working on local then no need to specify Microsoft App ID and Microsoft App Password ).
  
![adaptivecardbot_1](https://user-images.githubusercontent.com/31923904/39425391-db580692-4c98-11e8-9da8-5d5fc5fb4db4.jpg)

  -The following screenshot shows the results of this chatbot running in the Bot Framework Channel Emulator.

![logging-output](https://user-images.githubusercontent.com/31923904/40838158-906e4f70-65ba-11e8-99b1-8c4f262debe6.png)

4.To check log of conversation check log.txt in the following path :Chat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\lab 03.2-Logging Chat Conversation\code\file logging 
 
![txtfile](https://user-images.githubusercontent.com/31923904/40839983-6d348aa8-65c2-11e8-84ad-a50034e37bc7.png)
                    