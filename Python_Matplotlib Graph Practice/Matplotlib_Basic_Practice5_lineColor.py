import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()

#Different Color test
plt.plot(x, np.sin(x-0), color='r')        
plt.plot(x, np.sin(x-1), color='#ffdd44') # 16bit rgb
plt.plot(x, np.sin(x-2), color=(1.0, 0.2, 0.3)) # rgb value
plt.plot(x, np.sin(x-3), color='y') # w, b, g, r, y or etc
plt.plot(x, np.sin(x-4), color='blue') # blue, red, green, purple or etc
plt.plot(x, np.sin(x-5), color='0.75') #color between white&black 0-1

#Save as .png file
fig.savefig('my_figure5.png')

plt.show()
