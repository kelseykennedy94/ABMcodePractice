class Node:
    def __init__(self, key):
        self.left = None
        self.right = None
        self.key = key

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

    def tree(self):
        if self.left:
            self.left.tree()
        print(self.key)
        if self.right:
            self.right.tree()

root = Node(4)
root.insert(1)
root.insert(2)
root.insert(3)
root.insert(5)
root.insert(6)
root.insert(7)


print("Left:")
root.left.tree()
print("Root:")
print(root.key)
print("Right:")
root.right.tree()
