import numpy as np

elements = []
numElements = int(input("Enter the number of elements in the array: "))

for i in range(numElements):
    element = int(input(f"Enter element {i+1}: "))
    elements.append(element)

print(f'Elements: {elements}')

numArrays = int(input("How many evenly sized small arrays do you want to make: "))

if len(elements) < numArrays:
    print("Elements are less than the desired number of arrays.")
else:
    smallArrays = np.array_split(elements, numArrays)
    print("Small arrays:")
    for arr in smallArrays:
        print(arr.tolist())
