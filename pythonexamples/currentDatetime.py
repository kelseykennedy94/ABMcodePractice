from datetime import datetime
import pytz

timezone = pytz.timezone('America/Denver')

currentDatetime = datetime.now(timezone)
print("Current date and time (MST):", currentDatetime)

currentYear = currentDatetime.year
print("Current year:", currentYear)

currentMonth = currentDatetime.strftime("%B")
print("Month in full:", currentMonth)

weekNumber = currentDatetime.strftime("%U")
print("Week number of the year:", weekNumber)

currentDate = currentDatetime.strftime("%Y-%m-%d")
print("Date:", currentDate)

dayOfMonth = currentDatetime.day
print("Day of the month:", dayOfMonth)
