import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()
ax = plt.axes()

x = np.linspace(0,10,100)
ax.plot(x, np.sin(x))

#Save as .png file
fig.savefig('my_figure4.png')

plt.show()
