import math

side = 6.8990123

area = (math.sqrt(3) / 4) * side**2
rounded_area = round(area)
decimal_area = round(area, 2)
decimal_area2 = '{:.3f}'.format(area)

print(rounded_area)
print(decimal_area)
print(decimal_area2)
