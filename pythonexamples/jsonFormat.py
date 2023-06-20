import json

def printStudents(students):
    print()
    for student in students:
        print("ID:", student["id"])
        print("Name:", student["name"])
        print("Gender:", student["gender"])
        print("Age:", student["age"])
        print("Phone:", student["phone"])
        print()

def convertToJson(students):
    jsonData = json.dumps(students)
    return jsonData

def formatPhoneNumber(phone_number):
    return "-".join([phone_number[:3], phone_number[3:6], phone_number[6:]])

students = [
    {"id": 1, "name": "John", "gender": "Male", "age": 30, "phone": "1234561234"},
    {"id": 2, "name": "Kelsey", "gender": "Female", "age": 29, "phone": "9876549876"},
    {"id": 3, "name": "Rownie", "gender": "Male", "age": 21, "phone": "5432165432"},
    {"id": 4, "name": "Israa", "gender": "Female", "age": 20, "phone": "7890127890"},
]

printStudents(students)

for student in students:
    student["phone"] = formatPhoneNumber(student["phone"])

jsonData = convertToJson(students)

print("JSON:")
print(jsonData)
print()

formatData = json.loads(jsonData)
print("Students with formatted phone numbers:")
printStudents(formatData)
