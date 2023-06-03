import random

list_1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print("List:", list_1)

selected_num = random.choice(list_1)

output = ""
for num in list_1:
    if num == selected_num:
        output += str(num) + " --> 0,"
    else:
        output += str(num) + ","

print("Random:", output)
