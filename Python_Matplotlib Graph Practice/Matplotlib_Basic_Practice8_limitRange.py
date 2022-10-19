import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()

#Different graph range or starting point
plt.plot(x, np.sin(x))

plt.xlim(10, 0)
plt.ylim(1.5,-1.5)
#or
#plt.axis([-1,11,-1.5,1.5])

#Save as .png file
fig.savefig('my_figure8.png')

plt.show()
