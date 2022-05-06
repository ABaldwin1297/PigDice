

using PigDice;

const int highScore = 180;
long games = 0;

var pigdice = new PigDiceGame();
var score = pigdice.Play();
    while(score < highScore) {
    games++;
    if(games % 100 == 0) {
        Console.WriteLine($"Number of games is {games}");
    }
    score = pigdice.Play();
}
Console.WriteLine(score);