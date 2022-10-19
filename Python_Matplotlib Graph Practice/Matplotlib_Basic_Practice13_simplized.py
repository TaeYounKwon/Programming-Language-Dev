import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')

x = np.linspace(0,10,30)
y = np.sin(x)
fig = plt.figure()



#draw graph with the simple instance
plt.subplot(3,1,1)
plt.plot(x,y,'-ok',color='white')

plt.subplot(3,1,2)
plt.plot(x, y, '-p',color='blue', markersize=15, linewidth=4, markerfacecolor='white', markeredgecolor='yellow',markeredgewidth='2')

plt.subplot(3,1,3)
plt.scatter(x,y,marker='o')

#Save as .png file
fig.savefig('my_figure13.png')

plt.show()
