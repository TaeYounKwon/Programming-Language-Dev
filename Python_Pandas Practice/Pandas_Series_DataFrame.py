from pandas import Series, DataFrame

fruit = Series([2500,3800,1200,600],index=['apple','banana','peer','cherry'])

# print(fruit)
# apple     2500
# banana    3800
# peer      1200
# cherry     600
# dtype: int64

#Print value & index
# print(fruit.values)
# [2500 3800 1200  600]
# print(fruit.index)
# Index(['apple', 'banana', 'peer', 'cherry'], dtype='object')

# Describe it as Dictionary
fruitData = {'apple':2500 , 'banana':3800, 'peer':1200, 'cherry':600}
fruit_2 = Series(fruitData)

# print(fruitData)
# {'apple': 2500, 'banana': 3800, 'peer': 1200, 'cherry': 600}
# print(type(fruitData))
# <class 'dict'>
# print(fruit_2) 
# apple     2500
# banana    3800
# peer      1200
# cherry     600
# print(type(fruit))
# dtype: int64
# <class 'pandas.core.series.Series'>

#Set up value and column's name
fruit.name = 'fruitPrice'
fruit.index.name = 'fruitName'
# print(fruit)
# fruitName
# apple     2500
# banana    3800
# peer      1200
# cherry     600
# Name: fruitPrice, dtype: int64

#Data Frame
fruitData = {
            'fruitName':['apple','banana','cherry','peer'],
            'fruitPrice':[2500,3800,6000,1200],
            'num':[10,5,3,8]          
             }

fruitFrame = DataFrame(fruitData)
# print(fruitFrame)
#   fruitName  fruitPrice  num
# 0     apple        2500   10
# 1    banana        3800    5
# 2    cherry        6000    3
# 3      peer        1200    8

# Change the column order
fruitFrame = DataFrame(fruitData, columns=['fruitPrice','num','fruitName'])
# print(fruitFrame)
#    fruitPrice  num fruitName
# 0        2500   10     apple
# 1        3800    5    banana
# 2        6000    3    cherry
# 3        1200    8      peer

# print(fruitFrame.fruitName)
# 0     apple
# 1    banana
# 2    cherry
# 3      peer
# Name: fruitName, dtype: object

#Add Column
fruitFrame['year']='2022'
#    fruitPrice  num fruitName  year
# 0        2500   10     apple  2022
# 1        3800    5    banana  2022
# 2        6000    3    cherry  2022
# 3        1200    8      peer  2022

#Add Series element
variable = Series([4,2,1],index=[0,2,3])
fruitFrame['stock'] = variable
# print(fruitFrame)
#    fruitPrice  num fruitName  year  stock
# 0        2500   10     apple  2022    4.0
# 1        3800    5    banana  2022    NaN
# 2        6000    3    cherry  2022    2.0
# 3        1200    8      peer  2022    1.0


#Drop elements
# print(fruit)
# fruitName
# apple     2500
# banana    3800
# peer      1200
# cherry     600
# Name: fruitPrice, dtype: int64

newFruit = fruit.drop('banana')
# print(newFruit)
# fruitName
# apple     2500
# peer      1200
# cherry     600
# Name: fruitPrice, dtype: int64

#if want to update in the same element, then
# ### = ###.drop('element')

fruitName = fruitData ['fruitName']
# print(fruitName)
# ['apple', 'banana', 'cherry', 'peer']

newFruitFrame = DataFrame(fruitData, index=fruitName, columns = ['fruitPrice','num'])
# print(newFruitFrame)
#         fruitPrice  num
# apple         2500   10
# banana        3800    5
# cherry        6000    3
# peer          1200    8
# if we don't set up the index, then it will automatically set up index with number(0~)
tmp = newFruitFrame.drop(['apple','banana'])
# print(tmp)
#         fruitPrice  num
# cherry        6000    3
# peer          1200    8


tmp2 = fruitFrame.drop(['num'],axis=1)
# print(fruitFrame)
# print(tmp2)
#    fruitPrice  num fruitName  year  stock
# 0        2500   10     apple  2022    4.0
# 1        3800    5    banana  2022    NaN
# 2        6000    3    cherry  2022    2.0
# 3        1200    8      peer  2022    1.0
#    fruitPrice fruitName  year  stock
# 0        2500     apple  2022    4.0
# 1        3800    banana  2022    NaN
# 2        6000    cherry  2022    2.0
# 3        1200      peer  2022    1.0

# Pandas Slice
fruitSliced = fruit['banana':'peer']
# print(fruitSliced)
# fruitName
# banana    3800
# peer      1200
# Name: fruitPrice, dtype: int64

# Basic Calculation of Series Element
fruit1 = Series([5,9,10,3],index=['apple','banana','cherry','peer'])
fruit2 = Series([3,2,9,5,10],index=['apple','orange','banana','cherry','mango'])

newFruit = fruit1 + fruit2
# print(newFruit)
# apple      8.0
# banana    18.0
# cherry    15.0
# mango      NaN
# orange     NaN
# peer       NaN
# dtype: float64

stateData1 = {'Ohio':[4,8,3,5],'Texas':[0,1,2,3]}
stateData2 = {'Ohio':[3,0,2,1,7],'Oregon':[5,4,3,6,0]}
stateFrame1 = DataFrame(stateData1, columns=['Ohio','Texas'],
                        index=['apple','banana','cherry','peer'])
stateFrame2 = DataFrame(stateData2,columns=['Ohio','Oregon'],
                        index=['apple','ornage','banana','cherry','mango'])
# print(stateFrame1)
# print(stateFrame2)

#         Ohio  Texas
# apple      4      0
# banana     8      1
# cherry     3      2
# peer       5      3

#         Ohio  Oregon
# apple      3       5
# ornage     0       4
# banana     2       3
# cherry     1       6
# mango      7       0

newStateFrame = stateFrame1 + stateFrame2
# print(newStateFrame)
#         Ohio  Oregon  Texas
# apple    7.0     NaN    NaN
# banana  10.0     NaN    NaN
# cherry   4.0     NaN    NaN
# mango    NaN     NaN    NaN
# ornage   NaN     NaN    NaN
# peer     NaN     NaN    NaN

#Data Sorting

fruitAscend = fruit.sort_values(ascending=True)
# print(fruitAscend)
# fruitName
# cherry     600
# peer      1200
# apple     2500
# banana    3800
# Name: fruitPrice, dtype: int64
fruitDescend =fruit.sort_values(ascending=False)
# print(fruitDescend)
# fruitName
# banana    3800
# apple     2500
# peer      1200
# cherry     600
# Name: fruitPrice, dtype: int64

fruitFrame = DataFrame(fruitData, index=fruitName, columns=['num','fruitPrice'])
# print(fruitFrame)
#         num  fruitPrice
# apple    10        2500
# banana    5        3800
# cherry    3        6000
# peer      8        1200
# print(fruitFrame.sort_index(ascending=False))
#         num  fruitPrice
# peer      8        1200
# cherry    3        6000
# banana    5        3800
# apple    10        2500

# print(fruitFrame.sort_index(axis=0))
# print(fruitFrame.sort_index(axis=1))
#         num  fruitPrice
# apple    10        2500
# banana    5        3800
# cherry    3        6000
# peer      8        1200
#         fruitPrice  num
# apple         2500   10
# banana        3800    5
# cherry        6000    3
# peer          1200    8

newSorted = fruitFrame.sort_values(by=['fruitPrice','num'])
print(newSorted)