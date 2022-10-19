from itertools import groupby
import pandas as pd

#German Credential website
german = pd.read_csv('http://freakonometrics.free.fr/german_credit.csv')

# print(type(german))
# <class 'pandas.core.frame.DataFrame'>

german_sample = german[['Creditability','Duration of Credit (month)','Purpose','Credit Amount']]

#Print information from online
# print(german_sample)
# print(german_sample.min())
# print(german_sample.max())
# print(german_sample.mean())

#Print the first 5 data set
sampleData = german_sample.head()
# print(sampleData)
#    Creditability  Duration of Credit (month)  Purpose  Credit Amount
# 0              1                          18        2           1049
# 1              1                           9        0           2799
# 2              1                          12        9            841
# 3              1                          12        0           2122
# 4              1                          12        0           2171

#Check how they are co-related
dataCorr = german_sample.corr()
# print(dataCorr)

#Calculate & Accounting using Group By 
german_sample = german[['Credit Amount','Type of apartment']]

creditAmount_grouped = german_sample['Credit Amount'].groupby(german_sample['Type of apartment'])
# print(creditAmount_grouped.mean())

# print(creditAmount_grouped.max())

german_sample = german[['Type of apartment','Sex & Marital Status','Credit Amount']]
for type, group in german_sample.groupby('Type of apartment'):
    print(type)
    print(group.head())
    
# 1
#    Type of apartment  Sex & Marital Status  Credit Amount
# 0                  1                     2           1049
# 1                  1                     3           2799
# 2                  1                     2            841
# 3                  1                     3           2122
# 5                  1                     3           2241
# 2
#     Type of apartment  Sex & Marital Status  Credit Amount
# 4                   2                     3           2171
# 6                   2                     3           3398
# 7                   2                     3           1361
# 8                   2                     2           1098
# 12                  2                     2           1957
# 3
#      Type of apartment  Sex & Marital Status  Credit Amount
# 29                   3                     3           4796
# 44                   3                     3           1239
# 69                   3                     3           2032
# 125                  3                     4           5103
# 146                  3                     3           2964    
  
for (type, sex), group in german_sample.groupby(['Type of apartment','Sex & Marital Status']):
    print(type, sex)
    print(group.head(n=3))
    
# 1
#    Type of apartment  Sex & Marital Status  Credit Amount
# 0                  1                     2           1049
# 1                  1                     3           2799
# 2                  1                     2            841
# 3                  1                     3           2122
# 5                  1                     3           2241
# 2
#     Type of apartment  Sex & Marital Status  Credit Amount
# 4                   2                     3           2171
# 6                   2                     3           3398
# 7                   2                     3           1361
# 8                   2                     2           1098
# 12                  2                     2           1957
# 3
#      Type of apartment  Sex & Marital Status  Credit Amount
# 29                   3                     3           4796
# 44                   3                     3           1239
# 69                   3                     3           2032
# 125                  3                     4           5103
# 146                  3                     3           2964
# 1 1
#      Type of apartment  Sex & Marital Status  Credit Amount
# 369                  1                     1           3021
# 777                  1                     1           3384
# 797                  1                     1           2319
# 1 2
#    Type of apartment  Sex & Marital Status  Credit Amount
# 0                  1                     2           1049
# 2                  1                     2            841
# 9                  1                     2           3758
# 1 3
#    Type of apartment  Sex & Marital Status  Credit Amount
# 1                  1                     3           2799
# 3                  1                     3           2122
# 5                  1                     3           2241
# 1 4
#     Type of apartment  Sex & Marital Status  Credit Amount
# 11                  1                     4           6187
# 14                  1                     4           1936
# 17                  1                     4           3213
# 2 1
#      Type of apartment  Sex & Marital Status  Credit Amount
# 50                   2                     1            640
# 97                   2                     1           4455
# 112                  2                     1           2366
# 2 2
#     Type of apartment  Sex & Marital Status  Credit Amount
# 8                   2                     2           1098
# 12                  2                     2           1957
# 33                  2                     2           1376
# 2 3
#    Type of apartment  Sex & Marital Status  Credit Amount
# 4                  2                     3           2171
# 6                  2                     3           3398
# 7                  2                     3           1361
# 2 4
#     Type of apartment  Sex & Marital Status  Credit Amount
# 48                  2                     4           1474
# 57                  2                     4           1053
# 78                  2                     4           1602
# 3 1
#      Type of apartment  Sex & Marital Status  Credit Amount
# 620                  3                     1           9277
# 749                  3                     1           2892
# 784                  3                     1           2149
# 3 2
#      Type of apartment  Sex & Marital Status  Credit Amount
# 423                  3                     2           2133
# 453                  3                     2           5743
# 467                  3                     2           5324
# 3 3
#     Type of apartment  Sex & Marital Status  Credit Amount
# 29                  3                     3           4796
# 44                  3                     3           1239
# 69                  3                     3           2032
# 3 4
#      Type of apartment  Sex & Marital Status  Credit Amount
# 125                  3                     4           5103    