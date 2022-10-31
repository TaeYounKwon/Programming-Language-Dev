import numpy as np
import matplotlib.pyplot as plt
import seaborn as sb
import pandas as pd
import scipy as sp

plt.style.use('dark_background')


tips = sb.load_dataset('tips')
print(tips.head())
#    total_bill   tip     sex smoker  day    time  size
# 0       16.99  1.01  Female     No  Sun  Dinner     2
# 1       10.34  1.66    Male     No  Sun  Dinner     3
# 2       21.01  3.50    Male     No  Sun  Dinner     3
# 3       23.68  3.31    Male     No  Sun  Dinner     2
# 4       24.59  3.61  Female     No  Sun  Dinner     4

bins = 20

plt.hist(x=tips.tip, rwidth=0.9, bins = bins, density= True)
plt.title("Tips")
plt.xlabel('tip')
plt.ylabel('Density')

average, sigma = tips.tip.mean(), tips.tip.std()
tip_min = tips.tip.min()
tip_max = tips.tip.max()
x = np.linspace(tip_max, tip_max, bins)
y = sp.stats.norm(average, sigma).pdf(x)
plt.plot(x,y, color='w')


plt.savefig('my_figure18.png')


plt.show()
