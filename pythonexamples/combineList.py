list_1 = [1]
list_2 = [1, 2]
list_3 = [1, 2, 3]
list_4 = [1, 2, 3, 4]

total_sum = 0

for num in [list_1, list_2, list_3, list_4]:
    total_sum += sum(num)

print("total:", total_sum)
