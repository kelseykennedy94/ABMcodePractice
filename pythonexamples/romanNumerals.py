def convertIntToRoman(number):
    romanNumerals = {
        100: 'C',
        90: 'XC',
        50: 'L',
        40: 'XL',
        10: 'X',
        9: 'IX',
        5: 'V',
        4: 'IV',
        1: 'I'
    }

    result = ''
    for value, numeral in romanNumerals.items():
        count = number // value
        result += numeral * count
        number -= value * count

    return result

for number in range(1, 101):
    romanNumerals = convertIntToRoman(number)
    print(f"{number} --> {romanNumerals}")


