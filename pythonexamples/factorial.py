def factorial(n):
    result = 1
    for i in range(2, n + 1):
        result *= i
    return result

def is_peterson(n):
    digits = [int(d) for d in str(n)]
    factorial_sum = sum(factorial(digit) for digit in digits)
    return n == factorial_sum

n = 5
factorial_of_n = factorial(n)
print(f"factorial: {factorial_of_n}")

n = 145
if is_peterson(n):
    print(f"{n} is a peterson number.")
else:
    print(f"{n} is not a peterson number.")
