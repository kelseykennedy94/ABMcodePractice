import json

def printStudents(students):
    print()
    for student in students:
        print("ID:", student["id"])
        print("Name:", student["name"])
        print("Gender:", student["gender"])
        print("Age:", student["age"])
        print("Phone:", formatPhoneNumber(student["phone"]))
        print("Address 1:", student["address"]["address1"])
        print("Address 2:", student["address"]["address2"])
        print("City:", student["address"]["city"])
        print("Postal Code:", student["address"]["postalCode"])
        print("Province:", student["address"]["province"])
        print("Country:", student["address"]["country"])
        print()

def formatPhoneNumber(phone_number):
    return "-".join([phone_number[:3], phone_number[3:6], phone_number[6:]])

def parseAddress(address):
    address_parts = address.split(", ")
    if len(address_parts) == 5:
        address1, address2 = address_parts[0].split(" ", 1)
        city = address_parts[1]
        postalCode = address_parts[3]
        province = address_parts[2]
        country = address_parts[4]
        return {
            "address1": address1,
            "address2": address2,
            "city": city,
            "postalCode": postalCode,
            "province": province,
            "country": country
        }
    else:
        return {
            "address1": "",
            "address2": "",
            "city": "",
            "postalCode": "",
            "province": "",
            "country": ""
        }

students = [
    {
        "id": 1,
        "name": "John",
        "gender": "Male",
        "age": 30,
        "phone": "1234561234",
        "address": parseAddress("21 cityside heath ne, calgary, alberta, n2l 3b5, canada")
    },
    {
        "id": 2,
        "name": "Kelsey",
        "gender": "Female",
        "age": 29,
        "phone": "9876549876",
        "address": parseAddress("32 downtown blvd se, edmonton, alberta, t4x 2y8, canada")
    },
    {
        "id": 3,
        "name": "Rownie",
        "gender": "Male",
        "age": 21,
        "phone": "5432165432",
        "address": parseAddress("15 westside ave nw, vancouver, british columbia, v8r 6s9, canada")
    },
    {
        "id": 4,
        "name": "Israa",
        "gender": "Female",
        "age": 20,
        "phone": "7890127890",
        "address": parseAddress("9 lakeside dr se, ottawa, ontario, k1p 5z9, canada")
    }
]

jsonData = json.dumps(students)

print("JSON:")
print()
print(jsonData)

print("Students with address information:")
printStudents(students)
