from numpy import double
from fastapi import FastAPI
import requests
from bs4 import BeautifulSoup

app = FastAPI()

#Route to find if the API work normally or not
@app.get("/iAmLive")
async def root(textToSearch):
    return {"response": true}

#Route to search a card prize
@app.get("/searchCard/{textToSearch}")
async def root(textToSearch):
    newLink = link + textToSearch
    page = requests.get(newLink, headers=headers)
    soup = BeautifulSoup(page.content, 'html.parser')

    try:
        linesx = soup.find_all("dt", {"class": "col-6 col-xl-5"})
        nr = findNumber(linesx)

        #I extract the dd (html) which also contains the price
        mydivs = soup.find_all("dd", {"class": "col-6 col-xl-7"})
        #I only extract the price
        price = str(mydivs[nr]).replace('<dd class="col-6 col-xl-7">', '').replace('€</dd>', '').replace(',', '.').replace(" ","")
        print("Price:", price)
        return {"price": double(price)}
    except:
        return {"price": 0}

def findNumber(arr):
    for i in range(0,len(arr),1):
        contr = str(arr[i]).replace('<dt class="col-6 col-xl-5">', '').replace('</dt>', '')
        if (contr == "Da"):
            return i
    return 0

link = "https://www.cardmarket.com/it/YuGiOh/Products/Search?searchString="
headers = {
    "User-Agent": 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36'}
