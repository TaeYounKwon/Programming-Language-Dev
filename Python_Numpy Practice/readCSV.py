import numpy as np

redwine=np.loadtxt(fname='winequality-red.csv',delimiter=';', skiprows=1)
# print(redwine)

#Sum
print('sum: ', redwine.sum())

#Average
print('Average: ',redwine.mean())

#axis
print('axis Total')
print(redwine.sum(axis=0))
print('\naxis Average')
print(redwine.mean(axis=0))

#print 1st column
print('\n1st Column')
print(redwine[:,0])

#print max values
print('\n max Values/Column')
print(redwine.max(axis=0))