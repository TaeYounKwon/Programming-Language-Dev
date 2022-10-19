
# %%

import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
births = pd.read_csv('https://raw.githubusercontent.com/jakevdp/data-CDCbirths/master/births.csv')
plt.style.use('dark_background')

# print(births)
#        year  month  day gender  births
# 0      1969      1  1.0      F    4046
# 1      1969      1  1.0      M    4440
# 2      1969      1  2.0      F    4454
# 3      1969      1  2.0      M    4548
# 4      1969      1  3.0      F    4548
# ...     ...    ...  ...    ...     ...
# 15542  2008     10  NaN      M  183219
# 15543  2008     11  NaN      F  158939
# 15544  2008     11  NaN      M  165468
# 15545  2008     12  NaN      F  173215
# 15546  2008     12  NaN      M  181235

# [15547 rows x 5 columns]

births['decade']= births['year']//10*10
# print(births.head())
#    year  month  day gender  births  decade
# 0  1969      1  1.0      F    4046    1960
# 1  1969      1  1.0      M    4440    1960
# 2  1969      1  2.0      F    4454    1960
# 3  1969      1  2.0      M    4548    1960
# 4  1969      1  3.0      F    4548    1960

print(births.pivot_table('births', index='decade', columns='gender', aggfunc='sum'))
# gender         F         M
# decade
# 1960     1753634   1846572
# 1970    16263075  17121550
# 1980    18310351  19243452
# 1990    19479454  20420553
# 2000    18229309  19106428

plt.figure()
# plt.plot(births.pivot_table('births',index='decade',columns='gender',aggfunc='sum'))
plt.plot(births.pivot_table('births',index='year',columns='gender',aggfunc='sum'))
plt.show()