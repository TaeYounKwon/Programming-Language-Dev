import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()
plt.subplot(2,1,1)
plt.plot(x, np.sin(x))
plt.subplot(2,1,2)
plt.plot(x, np.cos(x))
plt.subplot(2,2,1)
plt.plot(x, np.sin(x))
plt.subplot(2,2,2)
plt.plot(x, np.cos(x))

#Save as .png file
fig.savefig('my_figure3.png')


plt.show()
