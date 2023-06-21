import time

def formatTime(seconds, milliseconds):
    hours = seconds // 3600
    minutes = (seconds % 3600) // 60
    seconds = seconds % 60
    return "{:02d}:{:02d}:{:02d}:{:02d}".format(hours, minutes, seconds, milliseconds)

seconds = 0
milliseconds = 1
minValue = formatTime(seconds, milliseconds)
maxValue = ""

while True:
    if seconds == 24 and milliseconds == 0:
        maxValue = formatTime(seconds - 1, 99)
        break
    if seconds == 0 and milliseconds == 0:
        minValue = formatTime(seconds, milliseconds)
    time.sleep(0.01)
    milliseconds += 1
    if milliseconds == 100:
        seconds += 1
        milliseconds = 0

print(minValue)
print(maxValue)
