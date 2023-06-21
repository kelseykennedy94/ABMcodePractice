import numpy as np

matrix = np.array([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15], [16, 17, 18, 19, 20], [21, 22, 23, 24, 25]])

print(f'Original:\n{matrix}')

matrixTranspose = matrix.transpose()

np.fill_diagonal(matrixTranspose, 0)

np.fill_diagonal(np.fliplr(matrixTranspose), 1)

print(f'Transposed:\n{matrixTranspose}')
