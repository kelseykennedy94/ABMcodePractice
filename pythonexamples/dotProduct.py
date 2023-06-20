a = [0.2, 0.2, 0.5, 0.6, 1, 1]
b = [0.1, 0.2, 0.3, 0.4, 0.9, 0.9]

dotProduct = sum(ai * bi for ai, bi in zip(a, b))

print(dotProduct)