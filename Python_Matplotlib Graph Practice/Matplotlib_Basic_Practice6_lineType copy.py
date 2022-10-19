import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()

#Different type of line test
plt.plot(x, x+0, linestyle='solid')
plt.plot(x, x+1, linestyle='dashed')
plt.plot(x, x+2, linestyle='dotted')
plt.plot(x, x+3, linestyle='dashdot')

plt.plot(x, x+4, linestyle='-')
plt.plot(x, x+5, linestyle='--')
plt.plot(x, x+6, linestyle=':')
plt.plot(x, x+7, linestyle='-.')

#Save as .png file
fig.savefig('my_figure6.png')

plt.show()
