from datetime import datetime

def getDay(date):
    dateEntered = datetime.strptime(date, "%d %B %Y")
    
    dayOfWeek = dateEntered.weekday()
    
    days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
    
    return days[dayOfWeek]

date = input("Enter a date(date month year): ")

dayOfWeek = getDay(date)
print(f"The day of the week for {date} is {dayOfWeek}.")
