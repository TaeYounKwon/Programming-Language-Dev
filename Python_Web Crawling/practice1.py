import bs4
import requests

url = 'https://search.shopping.naver.com/search/category/100005307'
#image -> .contents, html-> .text
result = requests.get(url).text

bsObj = bs4.BeautifulSoup(result, 'html.parser')

# print(bsObj.find('a',{'class':'basicList_link__JLQJf'}).text)
items = bsObj.find_all('a',{'class':'basicList_link__JLQJf'})
print(items[0].text)
print(items[1].text)
print(items[2].text)
print(items[3].text)