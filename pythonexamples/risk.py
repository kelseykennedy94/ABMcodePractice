import random

def roll_dice():
    return random.randint(1, 6)

def get_player1_roll():
    return roll_dice()

def get_player2_roll():
    return roll_dice()

def print_continents():
    continents = ["North America", "South America", "Europe", "Asia", "Africa", "Australia"]
    print("\nContinents:")
    for continent in continents:
        print(continent)
    print("-" * 20)

def print_countries(player_continent, player_number):
    continent_countries = {
        "North America": ["USA", "Canada", "Mexico"],
        "South America": ["Brazil", "Argentina", "Peru"],
        "Europe": ["Germany", "France", "Spain"],
        "Asia": ["China", "India", "Japan"],
        "Africa": ["Egypt", "Kenya", "South Africa"],
        "Australia": ["Australia", "New Zealand", "Fiji"],
    }
    print()
    print(f"Countries in Player {player_number}'s Continent:")
    countries = continent_countries.get(player_continent, [])
    for country in countries:
        print(country)

def print_kings(player_continent, player_number):
    continent_kings = {
        "North America": "King A",
        "South America": "King B",
        "Europe": "King C",
        "Asia": "King D",
        "Africa": "King E",
        "Australia": "King F"
    }
    print(f"\nKing in Player {player_number}'s Continent:")
    king = continent_kings.get(player_continent, "Unknown")
    print(king)

def print_warriors(player_continent, player_number):
    continent_warriors = {
        "North America": 10,
        "South America": 10,
        "Europe": 10,
        "Asia": 10,
        "Africa": 10,
        "Australia": 10
    }
    print()
    print(f"Number of Warriors in Player {player_number}'s Continent:")
    warrior_count = continent_warriors.get(player_continent, 0)
    print(warrior_count)
    print("-" * 20)

def main():
    player1_roll = get_player1_roll()
    print("Player 1 Roll:", player1_roll)
    player2_roll = get_player2_roll()
    print("Player 2 Roll:", player2_roll)

    continents = ["North America", "South America", "Europe", "Asia", "Africa", "Australia"]
    continent_numbers = {1: "North America", 2: "South America", 3: "Europe", 4: "Asia", 5: "Africa", 6: "Australia"}

    player1_continent = continent_numbers[player1_roll]
    print("Player 1 Continent:", player1_continent)

    player2_continent = continent_numbers[player2_roll]
    print("Player 2 Continent:", player2_continent)

    print_continents()

    if player1_roll > player2_roll:
        print("\nPlayer 1 wins!")
        print_countries(player1_continent, 1)
        print_kings(player1_continent, 1)
        print_warriors(player1_continent, 1)

        print("\nTransfer of territories from Player 2 to Player 1:")
        print_countries(player2_continent, 1)
        print_kings(player2_continent, 1)
        print_warriors(player2_continent, 1)

    elif player1_roll < player2_roll:
        print("\nPlayer 2 wins!")
        print_countries(player2_continent, 2)
        print_kings(player2_continent, 2)
        print_warriors(player2_continent, 2)

        print("\nTransfer of territories from Player 1 to Player 2:")
        print_countries(player1_continent, 2)
        print_kings(player1_continent, 2)
        print_warriors(player1_continent, 2)

    else:
        print("\nIt's a tie! No transfer of territories.")

main()
