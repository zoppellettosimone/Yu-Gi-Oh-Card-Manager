Yu-Gi-Oh Card Manager
==============

You need to have MongoDb in your pc.

How to install MongoDb: 

        Link: https://www.mongodb.com/try/download/community

Into MongoDb (you can use MongoDB Compass) create Database: "yugiohCardDb" and the Collection "User".

Into User insert new Document and Write:

        {
            "_id" : "",
            "name" : "",
            "password" : ""
        }
        You can use the default id and choose your name and password you will log in with

        You can create multiple users, always creating different documents within "Users". 
        Each user will have only personal and visible data from him.

Into the app you log in with your Name and Password, you can test hand without log in.

Other Link:

        Yu-Gi-Oh card db api from: https://db.ygoprodeck.com/api-guide/

You can find the .exe file into: "Yu-Gi-Oh Card Manager\\YuGiOhCardManager\\YuGiOhCardManager\\bin\\Debug\\YuGiOhCardManager.exe"

Create a link with this .exe file and move the link where you want

Created By Simone Zoppelletto