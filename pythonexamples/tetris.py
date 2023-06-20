import random

def random_num():
    return random.randrange(1, 100)

def tetris():
    line_player1 = []
    line_player2 = []
    count_player1 = 0
    count_player2 = 0
    
    while len(line_player1) + len(line_player2) < 10:
        num_player1 = random_num()
        count_player1 += 1
        if num_player1 % 10 == 0:
            line_player1.append(num_player1)
            print(f"{num_player1} -- block # {count_player1} (Player 1)")
        
        if len(line_player1) + len(line_player2) >= 10:
            break
        
        num_player2 = random_num()
        count_player2 += 1
        if num_player2 % 10 == 0:
            line_player2.append(num_player2)
            print(f"{num_player2} -- block # {count_player2} (Player 2)")

    print("--------------------------")
    print("Game Over!")

    if len(line_player1) >= 10:
        print("Player 1 wins!")
        print(f"Loop size: {count_player1 + count_player2}")
    else:
        print("Player 2 wins!")
        print(f"Loop size: {count_player1 + count_player2}")

tetris()
