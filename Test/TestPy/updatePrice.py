from pymongo import MongoClient
from bs4 import BeautifulSoup
import requests
import pprint

def findNumber(arr):
    for i in range(0,len(arr),1):
        contr = str(arr[i]).replace('<dt class="col-6 col-xl-5">', '').replace('</dt>', '')
        if (contr == "From"):
            return i
    return 0

# Creating an instance of MongoClient 
# on default localhost
client = MongoClient('mongodb://localhost:27017')

# Accessing desired database and collection
db = client.CardDb
collection = db["WantCard"]

for item in collection.find():
    pprint.pprint(item)

    cardToSearch = item["name"]

    link = f'https://www.cardmarket.com/en/YuGiOh/Products/Singles?idExpansion=0&searchString={cardToSearch}&idRarity=0&sortBy=price_asc&perSite=30'
    headers = {
        "User-Agent": 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36'}

    page = requests.get(link, headers=headers)
    soup = BeautifulSoup(page.content, 'html.parser')
    allRis = soup.find_all("div", { "class": "row no-gutters"})
    #newLink = test[0].find_all("div", { "class": "row no-gutters"}).find_all("a")
    ris = allRis[1].find_all("a")
    firstRis = ris[0]
    #aggiungere "CardMarket.com" row no-gutters

    indexFirstRis = str(firstRis).replace('<a href="', '').index('"')
    link = "http://www.cardmarket.com" + str(firstRis).replace('<a href="', '')[:indexFirstRis] + "?sellerCountry=17&language=1,5"
    print(link)

    page = requests.get(link, headers=headers)
    soup = BeautifulSoup(page.content, 'html.parser')

    linesx = soup.find_all("dt", {"class": "col-6 col-xl-5"})
    nr = findNumber(linesx)

    #I extract the dd (html) which also contains the price
    mydivs = soup.find_all("dd", {"class": "col-6 col-xl-7"})
    #I only extract the price
    price = str(mydivs[nr]).replace('<dd class="col-6 col-xl-7">', '').replace('€</dd>', '').replace(',', '.').replace('</dd>','').replace(" ", "")

    #Card Name
    title = soup.find_all("div", {"class": "flex-grow-1"})

    allCardName = str(title[0]).replace('<div class="flex-grow-1"><h1>', '')
    indexToRemove = allCardName.index('<')
    cardName = allCardName[:indexToRemove]

    print("--> P: " + price)
    print("--> C: " + cardName)

    collection.update_many(
        {"name": { "$eq": cardName } },
            {
                "$set": { "price" : price }
            }
    )

print("\nAggiornamento Riuscito")