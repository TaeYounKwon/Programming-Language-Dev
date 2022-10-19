import seaborn as sns
import pandas as pd
planets = sns.load_dataset('planets')
# print(planets)
#                method  number  orbital_period   mass  distance  year
# 0     Radial Velocity       1      269.300000   7.10     77.40  2006
# 1     Radial Velocity       1      874.774000   2.21     56.95  2008
# 2     Radial Velocity       1      763.000000   2.60     19.84  2011
# 3     Radial Velocity       1      326.030000  19.40    110.62  2007
# 4     Radial Velocity       1      516.220000  10.50    119.47  2009
# ...               ...     ...             ...    ...       ...   ...
# 1030          Transit       1        3.941507    NaN    172.00  2006
# 1031          Transit       1        2.615864    NaN    148.00  2007
# 1032          Transit       1        3.191524    NaN    174.00  2007
# 1033          Transit       1        4.125083    NaN    293.00  2008
# 1034          Transit       1        4.187757    NaN    260.00  2008

# [1035 rows x 6 columns]

#check how many rows x columns in the data
dataSizeCheck = planets.shape
# print(dataSizeCheck)
# (1035, 6)

dataHead = planets.head(n=5)
# print(dataHead)
#  method  number  orbital_period   mass  distance  year
# 0  Radial Velocity       1         269.300   7.10     77.40  2006
# 1  Radial Velocity       1         874.774   2.21     56.95  2008
# 2  Radial Velocity       1         763.000   2.60     19.84  2011
# 3  Radial Velocity       1         326.030  19.40    110.62  2007
# 4  Radial Velocity       1         516.220  10.50    119.47  2009


