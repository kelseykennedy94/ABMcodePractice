without regex:

import re

email = "Basantgera29@gmail.com"

if "@" not in email:
    print("Invalid email: Missing @ symbol")
    exit()

if not re.search(r"[A-Z]", email):
    print("Invalid email: Missing uppercase letter")
    exit()

if not re.search(r"[a-z]", email):
    print("Invalid email: Missing lowercase letter")
    exit()

if not email.endswith(".com"):
    print("Invalid email: Does not end in .com")
    exit()

print("Valid email")

with regex:

import re

email = "Basantgera29@gmail.com"

if not re.match(r"(?=.*@)(?=.*[A-Z])(?=.*[a-z]).*\.com$", email):
    print("Invalid email")
    exit()

print("Valid email")
