import random

def array(players, arr):
    random.shuffle(arr)
    
    player_1 = arr[:10]
    player_2 = arr[10:]
    
    print(f"{players[0]}: {player_1}")
    print(f"{players[1]}: {player_2}")
    
    while len(arr) != 0:
        for i, j in zip(player_1, player_2):
            if i in arr:
                arr.remove(i)
                print(f"{players[0]} has removed {i}, array {len(arr)} left")
            if j in arr:
                arr.remove(j)
                print(f"{players[1]} has removed {j}, array {len(arr)} left")
    
    print(f"{players[0]} array: {player_1}")
    print(f"{players[1]} array: {player_2}")
    print(f"Main array: {arr}")

players = ["player 1", "player 2"]
arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]
array(players, arr)
