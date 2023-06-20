from itertools import permutations

def gen_combos(num):
    digits = list(str(num))
    combinations = []

    for perm in permutations(digits):
        combinations.append(int(''.join(perm)))

    return combinations

num = 12345
combinations = gen_combos(num)
print(combinations)
