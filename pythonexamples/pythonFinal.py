--------------------------------------------------------------------

Q1: Write a Python program to search a specific item in a singly linked list and return true if the item is found otherwise return false.

class Node:
#Initializes a new node with the given data.
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
#Initializes an empty linked list.
    def __init__(self):
        self.head = None

#Inserts a new node with the given data at the end of the linked list
    def insert(self, data):
        newNode = Node(data)
        if self.head is None:
            # If the linked list is empty, set the new node as the head.
            self.head = newNode
        else:
            # Traverse to the end of the linked list and insert the new node.
            current = self.head
            while current.next:
                current = current.next
            current.next = newNode

#Searches for a specific item in the linked list. Returns True if the item is found returns false if not.
    def search(self, item):
        current = self.head
        while current:
            if current.data == item:
                return True
            current = current.next
        return False

linkedList = LinkedList()
linkedList.insert(1)
linkedList.insert(2)
linkedList.insert(3)
linkedList.insert(4)
linkedList.insert(5)

itemSearch = 3
if linkedList.search(itemSearch):
    print(f"The item {itemSearch} is found.")
else:
    print(f"The item {itemSearch} is not found.")

--------------------------------------------------------------------

Q2: Write a Python program to delete the first item from a singly linked list.

class Node:
#Initializes a new node with the given data.
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
#Initializes an empty linked list.
    def __init__(self):
        self.head = None

#Inserts a new node with the given data at the end of the linked list.
    def insert(self, data):
        newNode = Node(data)
        if self.head is None:
            self.head = newNode
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = newNode

##Searches for a specific item in the linked list. Returns True if the item is found returns false if not.
    def search(self, item):
        current = self.head
        while current:
            if current.data == item:
                # Item found, return True.
                return True
            current = current.next
        # Item not found, return False.
        return False

#Deletes the first node from the linked list and updates the pointer to the second node.
    def deleteFirst(self):
        if self.head is not None:
            self.head = self.head.next

linkedList = LinkedList()
linkedList.insert(1)
linkedList.insert(2)
linkedList.insert(3)
linkedList.insert(4)
linkedList.insert(5)

itemSearch = 3
if linkedList.search(itemSearch):
    print(f"The item {itemSearch} is found.")
else:
    print(f"The item {itemSearch} is not found.")

print("Before deleting:")
current = linkedList.head
while current:
    print(current.data, end=" ")
    current = current.next
print()

linkedList.deleteFirst()

print("After deleting:")
current = linkedList.head
while current:
    print(current.data, end=" ")
    current = current.next
print()

--------------------------------------------------------------------

Q3: Write a Python program to append a new item to the end of the array. Then Update the same item and remove the same in the end. 

#appends a new item to the end of the array
def appendItem(array, item):
    array.append(item)

#updates the item at the specific inedx in the array with a new value
def updateItem(array, index, value):
    if index < len(array):
        array[index] += value

#removes the last item from the array
def removeLastItem(array):
    if array:
        return array.pop()

array = [1, 2, 3, 4, 5, 6, 7, 8, 9]
appendItem(array, 10)
print("appending new item:", array)

updateItem(array, 9, 10)
print("updating the item:", array)

removedItem = removeLastItem(array)
print("removing the item:", array)

--------------------------------------------------------------------

Q4: How do you find the missing number in a given integer array of 1 to 100 in python ?

#calculate the possible sum of integers from 1 to 100
def findMissingNumber(array):
    sum1 = sum(range(1, 101))
    
#calculate the actual sum of the given array
    actualSum = sum(array)
    
    missingNumber = sum1 - actualSum
    
    return missingNumber


intArr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
                 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56,
                 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                 75, 76, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92,
                 93, 94, 95, 96, 97, 98, 99, 100]  #missing number: 77

missingNumber = findMissingNumber(intArr)
print("Missing number:", missingNumber)

--------------------------------------------------------------------

Q5: How do you find duplicate numbers in an array if it contains multiple duplicates in python?

#finds and returns the duplicate numbers in the array
def findDuplicates(array):
    seen = set()
    duplicates = set()
    
    for num in array:
        if num in seen:
            duplicates.add(num)
        else:
            seen.add(num)
    
    return duplicates

intArr = [1, 2, 3, 4, 5, 2, 7, 8, 3, 5, 9, 7, 2]
duplicates = findDuplicates(intArr)
print("Duplicates:", duplicates)

--------------------------------------------------------------------

Q6: How to find a median of two sorts arrays in Python?

#merge the two sorted arrays into one sorted array
def findMedian(nums1, nums2):
    merged = sorted(nums1 + nums2)
    
    length = len(merged)
    
    if length % 2 == 0:
        midRight = length // 2
        midLeft = midRight - 1
        median = (merged[midLeft] + merged[midRight]) / 2
    else:
        median = merged[length // 2]
    
    return median


nums1 = [1, 3, 5]
nums2 = [2, 4, 6]
median = findMedian(nums1, nums2)
print("Median:", median)

--------------------------------------------------------------------

Q7: Show me the step to implement Binary Search Algorithm in Python. Make sure you write the steps and leave the comments for the same. 

#perform binary search on sorted array
def binarySearch(arr, target):
    low = 0
    high = len(arr) - 1

    while low <= high:
        mid = (low + high) // 2

        if arr[mid] == target:
#target value found at the middle index
            return mid
        elif arr[mid] < target:
#target value is greater, adjust the search range to the right half
            low = mid + 1
        else:
#target value is smaller, adjust the search range to the left half
            high = mid - 1
#target value not found in the array
    return -1

arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
target = 8

result = binarySearch(arr, target)
if result != -1:
    print("Element found at index", result)
else:
    print("Element not found")


--------------------------------------------------------------------

Q8: How to remove duplicates from a given array in Python?

#convert array to a set to remove the duplicates
def removeDuplicates(array):
    newArray = list(set(array))
    return newArray

arr = [1, 2, 3, 4, 3, 2, 1, 5]
result = removeDuplicates(arr)
print(result)

--------------------------------------------------------------------

Q9: Make BST tree on your end. Insert the element in it. And traverse all 3 order to get the nodes. In order , Pre order , Post Order

class Node:
#initialize nodes in the binary search tree
    def __init__(self, key):
        self.left = None
        self.right = None
        self.key = key

#insert keys into the binary search tree
    def insert(self, key):
        if self.key:
            if key < self.key:
                if self.left is None:
                    self.left = Node(key)
                else:
                    self.left.insert(key)
            elif key > self.key:
                if self.right is None:
                    self.right = Node(key)
                else:
                    self.right.insert(key)
        else:
            self.key = key

#traverse the left subtree, print the key of the current node, traverse the right subtree
    def tree(self):
        if self.left:
            self.left.tree()
        print(self.key)
        if self.right:
            self.right.tree()

#perform inorder traversal and return the keys in order
    def inorderTraversal(self):
        elements = []
        if self.left:
            elements.extend(self.left.inorderTraversal())
        elements.append(self.key)
        if self.right:
            elements.extend(self.right.inorderTraversal())
        return elements

#perform preorder traversal and return the keys in preorder
    def preorderTraversal(self):
        elements = []
        elements.append(self.key)
        if self.left:
            elements.extend(self.left.preorderTraversal())
        if self.right:
            elements.extend(self.right.preorderTraversal())
        return elements

#perform postorder traversal and return the keys in postorder
    def postorderTraversal(self):
        elements = []
        if self.left:
            elements.extend(self.left.postorderTraversal())
        if self.right:
            elements.extend(self.right.postorderTraversal())
        elements.append(self.key)
        return elements

#create the root node
root = Node(4)

#insert keys into the binary search tree
root.insert(1)
root.insert(2)
root.insert(3)
root.insert(5)
root.insert(6)
root.insert(7)

#traverse and print the keys in the left subtree
print("Left:")
root.left.tree()

#print the key of the root node
print("Root:")
print(root.key)

#traverse and print the keys in the right subtree
print("Right:")
root.right.tree()

#perform inorder traversal and print the keys
print("Inorder:")
print(root.inorderTraversal())

#perform preorder traversal and print the keys
print("Preorder:")
print(root.preorderTraversal())

#perform postorder traversal and print the keys
print("Postorder:")
print(root.postorderTraversal())


