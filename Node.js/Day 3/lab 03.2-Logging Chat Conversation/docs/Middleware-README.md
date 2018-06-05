## Middleware and Logging with BotBuilder Node SDK

This is a basic bot that logs incoming and outgoing messages to the console.


### Adding Middleware Using the BotBuilder Node SDK 
In the Node SDK, middleware is installed using [UniversalBot.use](https://docs.botframework.com/en-us/node/builder/chat-reference/classes/_botbuilder_d_.universalbot.html#use). There are three possible hooks: receive, botbuilder and send. The team that build this SDK created the receive hook to be used for middleware that works across multiple toolkits (i.e., BotBuilder & BotKit). If this is your specific use case, be aware that if you include middleware in botbuilder, receive will execute first, followed by botbuilder. Because this example (and most bots) do not fit this category, we will be using the botbuilder hook for incoming messages.

#### Simplest Code Example Incoming messages (user -> bot)
Capturing User Input:
 ```javascript
     botbuilder: function (session, next) {
        console.log(session.message.text);
        next();
    }
```

The botbuilder hook on the middleware is an example of [ISessionMiddleware](https://docs.botframework.com/en-us/node/builder/chat-reference/interfaces/_botbuilder_d_.isessionmiddleware.html). The main advantage of using this hook instead of receive is the access we gain to the [session](https://docs.botframework.com/en-us/node/builder/chat-reference/classes/_botbuilder_d_.session.html#sessionstate). This will execute once a message is bound to a particular session and gives the option of looking at a message and the state of the session (where user is in available dialogs, etc) then making a decision of how to proceed. In this example, the default bot behavior is suppressed a message is sent to the user, all in middleware based on user input.

The second parameter `next` is a function called to advance the middleware. Calling `next` in the last step of middleware causes the bot code to execute. If you want to suppress the functionality of the bot, return instead of calling `next`.

#### Outgoing messages (bot -> user)
Capturing bot output to a user:
```javascript
    send: function (event, next) {
        console.log(event.text);
        next();
    }
```

Both the send and receive hooks use [IEventMiddleware](https://docs.botframework.com/en-us/node/builder/chat-reference/interfaces/_botbuilder_d_.ieventmiddleware.html). 
The first argument is the event itself. To see whether an event is a message, check to see if event.type is 'message'.

The second parameter `next` is the same function called in the botbuilder hook.


Misc:
- Uncaught errors in middleware code will often cause a silent failure and execution of code falls through to the bot, even without calling `next`.

### More Information

To get more information about how to get started in Bot Builder for Node and Middleware please review the following resources:
* [Bot Builder for Node.js Reference](https://docs.microsoft.com/en-us/bot-framework/nodejs/)
* [Intercept messages](https://docs.microsoft.com/en-us/bot-framework/nodejs/bot-builder-nodejs-intercept-messages)


###

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

To check implementation of this lab please refer to the following file in this path Chat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\lab 03.2-Logging Chat Conversation\code\Middleware logging:

```
                             middleware_logging.js
```

### Check implementation through following steps

1. Open middleware_logging.js file in SubLime Text Editor and provide Bot Framework App ID and Bot Framework App password in this section of code. (note : If you are working on local then there is no need to specify Bot Framework App ID and Bot Framework App password  ).

![adaptivecardbot_0](https://user-images.githubusercontent.com/31923904/39425015-f9250e9c-4c96-11e8-9636-f53ed8cc1a82.jpg)

2.Open command prompt (cmd) then set path to Middleware logging folder then run middleware_logging.js file using command below:
```

                               node middleware_logging.js.
```
3.Start the Bot Framework Emulator and connect your bot and type http://localhost:3978/api/messages into the address bar.(This is the default end point that your bot listens to when hosted locally).Click on “Connect” button.(note : If you are working on local then no need to specify Microsoft App ID and Microsoft App Password ).
  
![adaptivecardbot_1](https://user-images.githubusercontent.com/31923904/39425391-db580692-4c98-11e8-9da8-5d5fc5fb4db4.jpg)

  -The following screenshot shows the results of this chatbot running in the Bot Framework Channel Emulator.
![logging-output](https://user-images.githubusercontent.com/31923904/40838158-906e4f70-65ba-11e8-99b1-8c4f262debe6.png)

  -The following screenshot shows the results of this chatbot running in the console.

![console](https://user-images.githubusercontent.com/31923904/40838154-8e0cd2ce-65ba-11e8-8a88-972ce1375342.png)


