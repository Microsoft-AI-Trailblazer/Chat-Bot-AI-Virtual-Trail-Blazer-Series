# Development and Testing with Ngrok
 
## 1.	Objectives
 
With Microsoft Bot Framework, to configure a bot to be available for a particular channel, you will need to host the Bot service on a public URL endpoint. The channel will not be able to access your bot service if it is on a local server port hidden behind a NAT or firewall.
  
When designing / building / testing your code, you do not always want to keep redeploying. This will result in additional hosting costs. This is where ngrok can really help in speeding up the development/testing phases of bots. The goal of this lab is to use ngrok to expose your bot to public internet and use the public endpoints to test your bots in the emulator.
  
## 2.	Setup
  
 a.If you do not have ngrok installed, download ngrok from https://ngrok.com/download and install for your OS. Unzip ngrok file downloaded and install it.

 b.	Open echobot.js bot in following path Chat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\Testing Bot\code then run echobot.js.



## 3.	Forwarding

 a.Given the bot is being hosted on localhost:3979, we can use ngrok to expose this port to the public internet

 b.	 Open terminal and go to the folder where ngrok is installed
 
 c.	 Run the below command and you should see the forwarding url:

 ````ngrok.exe http 3979 -host-header="localhost:3979"````

![cmd](https://user-images.githubusercontent.com/31923904/40822187-ad56c900-6588-11e8-9f5f-1e6e599fcfaa.png)

 d.	 Enter the forwarding url (http) in the bot emulator. The bot url will have /api/messages appended to the forwarding url. Test the bot in the emulator by sending messages. We have now used a public endpoint instead of localhost to test the bot.

![ngrok](https://user-images.githubusercontent.com/31923904/40871680-cb942a18-665d-11e8-9735-5165c64aab99.png)
