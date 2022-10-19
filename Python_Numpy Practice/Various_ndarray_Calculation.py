import numpy as np

#Calculation of ndarray 
arr1 = np.array([[1,2],[3,4]])
arr2 = np.array([[5,6],[7,8]])

#ndarray adding up
arr_added = arr1 + arr2
arr_added2 = np.add(arr1,arr2)

# print(arr_added)
# print(arr_added2)

#ndarray multiply
arr_mult = arr1 * arr2
arr_mult2 = np.multiply(arr1, arr2)

# print(arr_mult)
# print(arr_mult2)

#ndarray array slicing
arr = np.array([[1,2,3],[4,5,6],[7,8,9]])
# 1,2,3
# 4,5,6
# 7,8,9
arr_sliced = arr[:2,1:3]

# 2,3
# 5,6
#arr[세로 값:가로 값]
# print(arr)
# print('-----------')
# print(arr_sliced)

#앞에는 세로값, 뒤에는 가로값
arr_sliced2 = arr[[0,1,2],[2,0,1]]
# print(arr_sliced2)


#Returns True or False
inx = arr>3
print(inx)

#Print if arr>3
print(arr[inx])