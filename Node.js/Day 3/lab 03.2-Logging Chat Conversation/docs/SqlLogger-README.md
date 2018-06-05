# SQL Logger

The aim of this lab is to log chat conversations to Azure SQL database. 

## 2.Setup/Pre-requisites

2.1 Open Microsoft Azure portal

2.2  Since we will be writing to a SQL database. To create a new one, go to the azure portal and follow the [Create DB - Portal](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-get-started-portal) steps. But create a database called Botlog, not "MySampleDatabase" as suggested in the link. At the end of the process, you should see the Overview tab, as you can see in the image below.

NOTE:Please note down following credential in notepad while creating Azure SQL database :

* Server name:XXXX.database.windows.net
* server login:xxxxx
* server password:xxxxx
* Database name:xxxxx

![botlog](https://user-images.githubusercontent.com/31923904/40843324-39a3cbc0-65ce-11e8-81a4-209da7a3fa61.png) 

2.3.   Change your firewall settings to capture your ip address. You may have already done this if you followed the steps from [Create DB - Portal](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-get-started-portal) . Your ip address can be found here: https://whatismyipaddress.com/ 

![firewallsettings](https://user-images.githubusercontent.com/31923904/40846685-efd0057c-65d7-11e8-9b62-3845549bacff.png)


2.4.   Create a new table called userChatLog with the below create table statement (or schema). We will use the same tool of the "Query the SQL database" section at the [Create DB - Portal](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-get-started-portal) link. Within the Azure Portal, click "Data Explorer (preview)" on the left menu. To login, use the same account and password you specified when creating the database. Paste the script below and click "Run". The expected result is the message "Query succeeded: Affected rows: 0.". 

```
CREATE TABLE userChatLog(id int IDENTITY(1, 1),fromId varchar(25),toId varchar(25),message varchar(max),PRIMARY KEY(id));

```

2.5 To check implementation of this lab please refer to the following file in this path Chat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\lab 03.2-Logging Chat Conversation\code\sql logging:

```
                             sql_logging.js
```

2.6 open sql_logging file in the path hat-Bot-AI-Virtual-Trail-Blazer-Series\Node.js\Day 3\lab 03.2-Logging Chat Conversation\code\sql logging and provide all credential which you noted down in notepad during creation of Azure Database in Azure portal.

![congi](https://user-images.githubusercontent.com/31923904/40871378-221ca1ea-6658-11e8-873a-df4640d16730.png)

2.7 Open command prompt (cmd) then set path to sql logging folder then run HelloBot.js file using command below:
```

                               node sql_logging.js
```
2.8 Start the Bot Framework Emulator and connect your bot and type http://localhost:3978/api/messages into the address bar.(This is the default end point that your bot listens to when hosted locally).Click on “Connect” button.(note : If you are working on local then no need to specify Microsoft App ID and Microsoft App Password ).
  
![adaptivecardbot_1](https://user-images.githubusercontent.com/31923904/39425391-db580692-4c98-11e8-9da8-5d5fc5fb4db4.jpg)

2.9 The following screenshot shows the results of this chatbot running in the Bot    Framework Channel Emulator.

![logging-output](https://user-images.githubusercontent.com/31923904/40853466-c3903f5e-65eb-11e8-9dd7-6133533aa2ef.png)

3.0 open Azure portal then from the database page of the portal, select Tools -> Query editor (preview) to preview log messages stored in the table. Login to run any queries. This is a quick way to see results but is not the only way of doing it. Feel free to use any SQL client to perform query operations. Run the query Select * from userChatLog to view chat inserts into the table userChatLog. In the below example, the message You sent A message which was 9 Characters sent via the bot emulator is logged along with the ids.

![chatlog](https://user-images.githubusercontent.com/31923904/40853721-b8aaea48-65ec-11e8-9820-4e4d0c58600c.png)

 


