from sklearn.datasets import load_iris
import numpy as np
import matplotlib.pyplot as plt

plt.style.use('dark_background')

fig = plt.figure()
iris=load_iris()

# print(type(iris))
# <class 'sklearn.utils._bunch.Bunch'>

# see full Iris Data
# print(iris.data)
# print(iris.data.T)
features = iris.data.T
plt.scatter(features[0],features[1],s=100*features[3],cmap='viridis', alpha=0.3)
plt.xlabel(iris.feature_names[0])
plt.ylabel(iris.feature_names[1])

#Save as .png file
fig.savefig('my_figure15.png')


plt.show()
