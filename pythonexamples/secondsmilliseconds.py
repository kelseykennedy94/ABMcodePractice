from datetime import datetime

date1Input = input("Enter the first date/time (YYYY-MM-DD HH:MM:SS.sss): ")
date1 = datetime.strptime(date1Input, "%Y-%m-%d %H:%M:%S.%f")

date2Input = input("Enter the second date/time (YYYY-MM-DD HH:MM:SS.sss): ")
date2 = datetime.strptime(date2Input, "%Y-%m-%d %H:%M:%S.%f")

secondsDiff = (date2 - date1).total_seconds()
print("Difference in seconds:", secondsDiff)

millisecondsDiff = secondsDiff * 1000
print("Difference in milliseconds:", millisecondsDiff)
