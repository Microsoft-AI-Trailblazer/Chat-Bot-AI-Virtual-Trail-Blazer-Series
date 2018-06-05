# Cortana Bot 

In this lab you will build a voice enabled bot which interacts through the voice and collects the information such as name,city,company from the user and display the summary to the user.

### Prerequisites
The following software environment is needed for running this bot :

```
1.Visual Studio 2017
2.Microsoft BotFramework Emulator.
3.Bot Application template.
```

### Collecting the keys

Over the course of this lab, we will collect various keys. It is recommended that you save all of them in a text file, so you can easily access them throughout the workshop.keys:

```
-Bot Framework App ID.
-Bot Framework App password.
```

Note:Please refer following link to understand how to register bot and generate Bot Framework APP ID and App password.  link :[Bot Registration](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-3.0).

Note:Please enable Cortana Channel after registartion.To understand how to enable cortana channel please refer following link :[Cortana Registration](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-channel-connect-cortana?view=azure-bot-service-3.0).
### Implementation

To check implementation of this lab please refer to the following file in this path Chat-Bot-AI-Virtual-Trail-Blazer-Series\C#\Day 1\lab 01.5-Cortana Bot\Cortanabot:

```
                             Cortanabot.sln
```

### Check implementation through following steps

1. Open Visual studio 2017.
2. In visual studio go to File->open->project then set path to lab 01.5-Cortana Bot folder (Chat-Bot-AI-Virtual-Trail-Blazer-Series\C#\Day 1\lab 01.5-Cortana Bot\Cortanabot) and open Cortanabot.sln file.
3. Solution in visual studio is opened and  we have to provide Bot Framework App ID and Bot Framework App password in Web.config file.(note : If you are working on local then specify Bot Framework App ID and Bot Framework App password )
 
![cortanaweb](https://user-images.githubusercontent.com/31923904/40821673-0012afe0-6586-11e8-9547-24819f80b491.png)


4.When you click the IIS Express (Google chrome) button, Visual Studio will build the application, deploy it to local host, and launch the web browser to display the application's host name as http://localhost:3979 in address bar of web browser.

5.Start the Bot Framework Emulator and connect your bot and type http://localhost:3979/api/messages into the address bar.(This is the default end point that your bot listens to when hosted locally).Click on “Connect” button.(note : If you are working on local then no need to specify Microsoft App ID and Microsoft App Password ).

![botemulator](https://user-images.githubusercontent.com/31923904/40710991-b411a8fe-6417-11e8-96e9-7bad98d7a192.png)


  -The following screenshot shows the results of this chatbot running in the Bot Framework Channel Emulator.

![cortanabot](https://user-images.githubusercontent.com/31923904/40911930-c94ed472-680d-11e8-9c54-932e4a719370.png)
                                    





