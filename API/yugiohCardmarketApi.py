from numpy import double
from fastapi import FastAPI
from datetime import datetime as d
import requests
from bs4 import BeautifulSoup

app = FastAPI()

#Route to find if the API work normally or not
@app.get("/iAmLive")
async def root():
    return {"response": True}

#Route to search a yugioh card prize
@app.get("/yugioh/searchCard/{limit}/{textToSearch}")
async def root(limit, textToSearch):
    print("Start: " + d.now().strftime("%Y-%m-%d %H:%M:%S"))
    newLink = link + textToSearch
    page = requests.get(newLink, headers=headers)
    soup = BeautifulSoup(page.content, 'html.parser')

    try:
        linesx = soup.find_all("dt", {"class": "col-6 col-xl-5"})

        nr = 0;

        if(limit == "min"):
            nr = findMinNumber(linesx)
        elif(limit == "med"):
            nr = findHalfNumber(linesx)
        #I extract the dd (html) which also contains the price
        mydivs = soup.find_all("dd", {"class": "col-6 col-xl-7"})
        #I only extract the price
        price = str(mydivs[nr]).replace('<dd class="col-6 col-xl-7">', '').replace('€', '').replace(',', '.').replace(" ","").replace("<span>","").replace("</span>","").replace("</div>","").replace("</dd>","")
        print("Price:", price + " ---> " + d.now().strftime("%Y-%m-%d %H:%M:%S"))
        return {"price": double(price)}
    except:
        return {"price": 0}

def findMinNumber(arr):
    for i in range(0,len(arr),1):
        contr = str(arr[i]).replace('<dt class="col-6 col-xl-5">', '').replace('</dt>', '')
        if (contr == "Da"):
            return i
    return 0

def findHalfNumber(arr):
    for i in range(0,len(arr),1):
        contr = str(arr[i]).replace('<dt class="col-6 col-xl-5">', '').replace('</dt>', '')
        if (contr == "Tendenza di prezzo"):
            return i
    return 0


link = "https://www.cardmarket.com/it/YuGiOh/Products/Search?searchString="
headers = {
    "User-Agent": 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36'}
