
# Logging with Microsoft Bot Framework

Unless your bot is logging the conversation data somewhere, the bot framework will not perform any logging for you automatically. This has privacy implications, and many bots simply can't allow that in their scenarios.

This workshop demonstrates how you can perform logging using Microsoft Bot Framework and store chat conversations. More specifically, the aim of this lab is to:

1. Understand how to intercept and log message activities between bots and users.

2. Log conversations to a file .

3. Extend the logging to SQL .

## Uses of logging chat conversations

In the advanced analytics space, there are plenty of uses for storing log conversations. Having a corpus of chat conversations can allow developers to: 
1. Build question and answer engines specific to a domain.
2. Introduce a personality to bots.
3. Perform analysis on specific topics or products to identify trends.

## Prerequisites

* The latest update of version of Node.js.

* The Bot Framework Emulator. To install the Bot Framework Emulator, download it from [here](https://emulator.botframework.com/). Please refer to [this documentation article](https://github.com/microsoft/botframework-emulator/wiki/Getting-Started) to know more about the Bot Framework Emulator.

* Access to portal and be able to create resources on Azure.

* Be familiar with Node.js and have some experience developing bots with Microsoft Bot Framework.

## Lab structure

The folder structure is arranged as follows:

__docs__: Contains all the hands-on labs

__code__: Contains all the code for the hands-on labs

The order of Hands-on Labs to carry out the solution is as follows:
1. [Middleware Logger](docs/Middleware-README.md):
The aim of this hands-on lab is to implement the middleware functionality that writes message activities on console when running in debug. 
2. [File Logger](docs/FileLogger-README.md):
This hands-on lab is to demonstrate how you can log conversations to a file .
3. [SQL Logger](docs/SqlLogger-README.md):
This hands-on lab is to demonstrate how you can log conversations in SQL.