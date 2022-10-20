import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
fig = plt.figure()
x = np.linspace(0,10,50)
dy = 0.8
y = np.sin(x) + dy * np.random.randn(50)

plt.errorbar(x,y,yerr=dy,fmt='o',color='w', ecolor='b', elinewidth=3, capsize=0)
#Save as .png file
fig.savefig('my_figure16.png')

plt.show()
