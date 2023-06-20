def find_sum(numbers, sum):
    pairs = []

    for i in range(len(numbers)):
        for j in range(i, len(numbers)):
            if numbers[i] + numbers[j] == sum:
                pairs.append((numbers[i], numbers[j]))

    return pairs

numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
sum = 10
pairs = find_sum(numbers, sum)

for pair in pairs:
    print(f"{pair[0]} + {pair[1]} = {sum}")
    if pair[0] != pair[1]:
        print(f"{pair[1]} + {pair[0]} = {sum}")
