var request = require('request');
require('dotenv-extended').load();
var restify = require('restify');
var builder = require('botbuilder');
var cognitiveservices=require('botbuilder-cognitiveservices');



// Setup Restify Server
var server = restify.createServer();
server.listen(process.env.port || process.env.PORT || 3978, function () {
   console.log('%s listening to %s', server.name, server.url); 
});

// Create chat connector for communicating with the Bot Framework Service
var connector = new builder.ChatConnector({
    appId: process.env.MicrosoftAppId,
    appPassword: process.env.MicrosoftAppPassword
    
});

// Listen for messages from users 
server.post('/api/messages', connector.listen());



// Create your bot with a function to receive messages from the user
var bot = new builder.UniversalBot(connector);


bot.dialog("/",[
  function(session)
  {
    qnamakercall(session);
  }
  ]);



function qnamakercall(session)
{

   var qa={
  question:session.message.text
};
request({
  
  headers:{
   'Authorization':process.env.Authorization,
   'Content-Type':'application/json'
  },
  
  uri:process.env.uri,
  body:JSON.stringify(qa),
  
  
  method: 'POST'
}, function (err, res, body) {
  if (err) {
    console.log(err);
  }
  else {
    var temp=JSON.parse(res.body)
    if(temp.answers[0].answer=='No good match found in KB.')
    {
     session.send("Sorry,I didn't get that yet.I am still learning.");
    }else{
      session.send(temp.answers[0].answer);
    }

    
  }
});


}







