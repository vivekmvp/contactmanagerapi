# Contact Manager Api
Simple Contact Manager Api Project for my Azure Practise

<kbd>![image](https://user-images.githubusercontent.com/30829678/214918257-51b8a918-2a64-40e8-a3ec-fb74f6cc6dc6.png)</kbd>


## Step 1: Create SQL Server database.
In order to create sql server database in azure, I have to first create sql database server and then database.

**Create SQL Server details:**
- *SQLServer name:* persondbsrvr.database.windows.net
- *Server admin login:* persondbadmin
- *Password:* dummypass@123

<kbd>![image](https://user-images.githubusercontent.com/30829678/214920829-3732c38d-3506-4c59-9c75-93531c11d818.png)</kbd>

Once database is created open a firewall for your IP Address
<kbd>![image](https://user-images.githubusercontent.com/30829678/214922078-909609b0-77d2-4caa-acf4-3045edee5496.png)</kbd>

<kbd>![image](https://user-images.githubusercontent.com/30829678/214922561-0daad3ed-b450-4e41-9ff6-bf120e09c91d.png)</kbd>

<kbd>![image](https://user-images.githubusercontent.com/30829678/214923120-3bbb3f40-0003-48fc-baa4-dbb2d6bd4ccb.png)</kbd>

-----

## Step 2: Create Web App for Api and Deploy the code through CLI commands

```
az login

az group create -n rg-prac -l eastus

az appservice plan create -n planname919 -g rg-prac --sku S1 

az webapp create -n 'contactmanagerapi4demo' -g 'rg-prac' --plan 'planname919'

az webapp deployment source config -n 'contactmanagerapi4demo'  -g 'rg-prac'  --repo-url https://github.com/vivekmvp/contactmanagerapi.git  --branch master --manual-integration
```

