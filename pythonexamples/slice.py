sentence = "My name is Basant and I am an instructor at ABM college, Calgary and Toronto Campus."

value_1_slice = slice(56, 64)  # Create a slice object for "Calgary"
value_2_slice = slice(69, 76)  # Create a slice object for "Toronto"

value_1 = sentence[value_1_slice]
value_2 = sentence[value_2_slice]

print(value_1)
print(value_2)
