import json

def printStudents(students):
    print()
    for student in students:
        print("ID:", student["id"])
        print("Name:", student["name"])
        print("Gender:", student["gender"])
        print("Age:", student["age"])
        print()

def convertToJson(students):
    jsonData = json.dumps(students)
    return jsonData

def filterStudentsByGender(students, gender):
    filteredStudents = [student for student in students if student["gender"] == gender]
    return filteredStudents

def updateStudentById(students, studentId, updatedName):
    for student in students:
        if student["id"] == studentId:
            student["name"] = updatedName
            break

def deleteStudentById(students, studentId):
    for student in students:
        if student["id"] == studentId:
            students.remove(student)
            break

students = [
    {"id": 1, "name": "John", "gender": "Male", "age": 30},
    {"id": 2, "name": "Kelsey", "gender": "Female", "age": 29},
    {"id": 3, "name": "Rownie", "gender": "Male", "age": 21},
    {"id": 4, "name": "Israa", "gender": "Female", "age": 20},
]

printStudents(students)

jsonData = convertToJson(students)

print("JSON:")
print()
print(jsonData)

maleStudents = filterStudentsByGender(students, "Male")
print("Male Students:")
printStudents(maleStudents)

femaleStudents = filterStudentsByGender(students, "Female")
print("Female Students:")
printStudents(femaleStudents)

updateStudentById(students, 3, "Dmytro")
print("Updated Student:")
printStudents(students)

deleteStudentById(students, 2)
print("Deleted Student:")
printStudents(students)
