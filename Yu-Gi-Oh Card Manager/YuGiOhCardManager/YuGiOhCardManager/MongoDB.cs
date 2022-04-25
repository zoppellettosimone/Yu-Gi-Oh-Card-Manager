using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOhCardManager
{
    class MongoDB
    {
        public static MongoClient Client = new MongoClient("mongodb://127.0.0.1:27017");

        public static bool IsConnected()
        {
            try
            {
                return MongoDB.Client.GetDatabase("yugiohCardDb").RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(2000);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
