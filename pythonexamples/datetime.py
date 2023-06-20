from datetime import datetime

def isPaymentRequired(date1, date2):
    date1 = datetime.strptime(date1, "%Y-%m-%d")
    date2 = datetime.strptime(date2, "%Y-%m-%d")

    monthsDiff = (date2.year - date1.year) * 12 + date2.month - date1.month

    if monthsDiff > 12:
        return True
    else:
        return False

date1 = input("Enter the first date (YYYY-MM-DD): ")
date2 = input("Enter the second date (YYYY-MM-DD): ")

if isPaymentRequired(date1, date2):
    print("Payment required.")
else:
    print("No payment required.")
