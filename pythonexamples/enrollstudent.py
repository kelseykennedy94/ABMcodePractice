courses = {
    1: {
        'name': 'Math',
        'capacity': 1,
        'students': []
    },
    2: {
        'name': 'English',
        'capacity': 1,
        'students': []
    }
}

students = {
    'basant': False,
    'kelsey': False,
    'rownie': False
}

def display_courses():
    print("Available Courses:")
    for course_id, course in courses.items():
        if not course['students']:
            print(f"{course_id}. {course['name']}")

def enroll_student(student_name, course_id):
    if student_name not in students or course_id not in courses:
        print("Invalid student or course.")
        return

    student_enrolled = students[student_name]
    if student_enrolled:
        print(f"{student_name} is already enrolled for a course.")
        return

    course = courses[course_id]
    if course['students']:
        print(f"The course '{course['name']}' is already full.")
        return

    course['students'].append(student_name)
    students[student_name] = True
    print(f"{student_name} is enrolled for {course['name']}.")

def unenroll_student(student_name):
    if student_name not in students:
        print("Invalid student.")
        return

    if not students[student_name]:
        print(f"{student_name} is not enrolled for any course.")
        return

    print(f"{student_name} is currently enrolled in the following course(s):")
    for course_id, course in courses.items():
        if student_name in course['students']:
            print(f"{course_id}. {course['name']}")
    
    unenroll_choice = int(input("Enter the course number to unenroll from (or 0 to cancel): "))
    if unenroll_choice == 0:
        return
    
    if unenroll_choice in courses:
        course = courses[unenroll_choice]
        if student_name in course['students']:
            course['students'].remove(student_name)
            students[student_name] = False
            print(f"{student_name} has been unenrolled from {course['name']}.")
        else:
            print(f"{student_name} is not enrolled in that course.")
    else:
        print("Invalid course number.")

while True:
    student_name = input("Enter your name (or 'exit' to quit): ")
    if student_name == 'exit':
        break

    if student_name in students:
        if students[student_name]:
            unenroll_student(student_name)
        else:
            display_courses()
            course_choice = int(input("Enter the course number you want to enroll in: "))
            enroll_student(student_name, course_choice)
    else:
        print("Invalid student.")

print("Exiting the program.")
