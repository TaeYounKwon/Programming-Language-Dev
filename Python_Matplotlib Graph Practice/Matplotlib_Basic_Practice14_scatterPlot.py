import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')

x = np.linspace(0,10,30)
y = np.sin(x)
fig = plt.figure()


#draw scatter plot
rng = np.random.RandomState(0)
x = rng.randn(100)
y = rng.randn(100)
color = rng.randn(100)
size = 1000 * rng.randn(100)

plt.scatter(x,y,s=size,c=color,cmap='viridis',alpha=0.3)
plt.colorbar()
#Save as .png file
fig.savefig('my_figure14.png')

plt.show()
