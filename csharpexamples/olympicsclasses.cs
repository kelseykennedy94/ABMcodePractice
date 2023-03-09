Class Country{
int countryId;
string name;
int capacity;
int noOfPlayers;
int noOfCoaches;
int medalTally;
string events;
}

Class Coach{
int coachId;
int countryId;
string name;
string sport;
}

Class Player{
int playerId;
string name;
string gender;
double weight;
}

Class MedalTally{
int medalId;
int countryId;
string gold;
string silver;
string bronze;
string runnerup;
}

Class SportsEvent{
int eventId;
int countryId;
int coachId;
int playerId;
int medalId;
string name;
string sport;
DateTime datePlayed;
string location;
int noOfTeams;
}