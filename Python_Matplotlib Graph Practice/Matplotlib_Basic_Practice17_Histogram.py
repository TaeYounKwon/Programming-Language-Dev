import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
np.random.seed(0)

average = 72
sigma = 8 # +8 or -8

x= np.random.normal(average,sigma, 1000)
#Save as .png file
plt.hist(x,rwidth=0.9, bins=16)

plt.savefig('my_figure17.png')


plt.show()
