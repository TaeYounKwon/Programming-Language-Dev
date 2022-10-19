import numpy as np
#Check array in numpy
arr = np.array([1,2,3,4,5])
print(arr)
print(type(arr))

#set up array with default zero value
arr = np.zeros((3,3))
print(arr)

#create 4 by 4 array with empty value 
##Since, didn't set up as 0, 
#random value could be in depends on the memroy location
arr = np.empty((4,4))
print (arr)

#create array filled with 1
arr = np.ones((3,3))
print(arr)

#내가 자주쓰던 배열
# tmp = []
# for i in range(3):
#     tmp.append([])
#     for j in range(3):
#         tmp[i].append(j)
# print(tmp)
# 출력값 : [[0, 1, 2], [0, 1, 2], [0, 1, 2]]    

# [[]] <- 이거 개수에 따라 차원 수를 알 수 있음 (현제 2차원)    

arr=np.arange(10)
print(arr)

arr=np.array([[1,2,3],[4,5,6]])

print(arr.shape)
print(arr.ndim)
print(arr.dtype)
arr_float = arr.astype(np.float64)

