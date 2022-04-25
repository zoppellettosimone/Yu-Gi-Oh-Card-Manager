using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch checkTime = new Stopwatch();

            //Chiamata Api
            string apiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

            //Stringa Json dalla chiamata Api
            string jsonString = "";

            checkTime.Start();
            //Chiamata Api
            Uri address = new Uri(apiUrl);
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
            request.Method = "GET";
            request.ContentType = "text/json";

            try
            {
                //Salvataggio su "jsonString" della risposta
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    jsonString = reader.ReadToEnd();
                }

                //Conversione da Json String a Json
                var allJsonContent = JObject.Parse(jsonString);

                //Estrazione dei dati
                List<Dictionary<string, object>> resList = allJsonContent["data"].Select(s => new Dictionary<string, object> {
                            { "name", s["name"].ToString() },
                            { "type", s["type"].ToString()},
                            { "race", s["race"].ToString()},
                            { "desc", s["desc"].ToString()},
                            { "attribute", s.ToObject<JObject>().ContainsKey("attribute") == true ? s["attribute"].ToString() : "Null" },
                            { "atk", s.ToObject<JObject>().ContainsKey("atk") == true ? int.Parse(s["atk"].ToString()) : 0},
                            { "def", s.ToObject<JObject>().ContainsKey("def") == true ? int.Parse(s["def"].ToString()) : 0},
                            { "level", s.ToObject<JObject>().ContainsKey("level") == true ? int.Parse(s["level"].ToString()) : 0},
                            { "linkval", s.ToObject<JObject>().ContainsKey("linkval") == true ? int.Parse(s["linkval"].ToString()) : 0},
                            { "imageId", s["card_images"][0]["id"].ToString()},
                            { "price", s["card_prices"][0]["cardmarket_price"].ToString()}
                                })
                                .ToList();

                checkTime.Stop();

                Console.WriteLine("C: " + resList.Count());

                Console.WriteLine(checkTime.ElapsedMilliseconds);

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }
    }
}
