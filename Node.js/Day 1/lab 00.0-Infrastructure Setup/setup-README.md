## 1_Setup:
Estimated Time: 30-40 minutes

### Lab: Setting up your Azure Account

You may activate an Azure free trial at [https://azure.microsoft.com/en-us/free/](https://azure.microsoft.com/en-us/free/).  

If you have been given an Azure Pass to complete this lab, you may go to [http://www.microsoftazurepass.com/](http://www.microsoftazurepass.com/) to activate it.  Please follow the instructions at [https://www.microsoftazurepass.com/howto](https://www.microsoftazurepass.com/howto), which document the activation process.  A Microsoft account may have **one free trial** on Azure and one Azure Pass associated with it, so if you have already activated an Azure Pass on your Microsoft account, you will need to use the free trial or use another Microsoft account.

### Lab 1.1: Setting up your Data Science Virtual Machine

After creating an Azure account, you may access the [Azure portal](https://portal.azure.com). From the portal, [create a Resource Group for this lab](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-portal). Detailed information about the Data Science Virtual Machine can be [found online](https://docs.microsoft.com/en-us/azure/machine-learning/data-science-virtual-machine/overview), but we will just go over what's needed for this workshop. We are creating a VM and not doing it locally to ensure that we are all working from the same environment. This will make troubleshooting much easier. In your Resource Group, deploy and connect to a "{CSP} Data Science Virtual Machine - Windows 2016", with a size of 2-4 vCPUs and 8-12 GB RAM, some examples include but are not limited to DS4_V3, B4MS, DS3, DS3_V2, etc. **Put in the location that is closest to you: West US 2, East US, West Europe, Southeast Asia**. All other defaults are fine. 
> Note: Testing was completed on both West US 2 DS4_V3 and Southeast Asia DS4_V3.

[Connect to your VM](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/connect-logon). Once you're connected, there are several things you need to do to set up the DSVM for the workshop:

1. In the Cortana search bar, type "git bash" and select "Git Bash Desktop App", or type "cmd" and select "Command Prompt". Next, type `cd c://` then enter, and `git clone https://github.com/jumpstartninjatech/Chat-Bot-AI-Virtual-Trail-Blazer-Series.git` then enter. This copies down all of the files from the GitHub site to **C:\Chat-Bot-AI-Virtual-Trail-Blazer-Series**.  
*Validation step*: Go to **C:\Chat-Bot-AI-Virtual-Trail-Blazer-Series** and confirm it exists.

### Lab 1.2: Download Bot Emulator 

[https://github.com/Microsoft/BotFramework-Emulator/releases](https://github.com/Microsoft/BotFramework-Emulator/releases)
