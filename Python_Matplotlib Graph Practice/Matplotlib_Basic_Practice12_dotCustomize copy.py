import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')

x = np.linspace(0,10,30)
y = np.sin(x)
fig = plt.figure()



#choose random dot shape to draw the points in the random location
rng = np.random.RandomState(0)
for marker in ['o',',','x','+','v','<','>','s','d']:
    plt.plot(rng.rand(5),rng.rand(5),marker, label='marker={0}'.format(marker))
    plt.legend()
    plt.xlim(0,1.8)
    
#Save as .png file
fig.savefig('my_figure12.png')

plt.show()
