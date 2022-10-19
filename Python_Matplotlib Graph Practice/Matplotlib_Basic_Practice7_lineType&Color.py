import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()

#Different type of line&color test
plt.plot(x, x+0, '-g')
plt.plot(x, x+1, '--c')
plt.plot(x, x+2, ':w')
plt.plot(x, x+3, '-.r')

#Save as .png file
fig.savefig('my_figure7.png')

plt.show()
