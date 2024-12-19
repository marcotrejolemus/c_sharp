using System.ComponentModel; // Importing a namespace (not used in this example but can be removed if unnecessary)

int heroHealth = 10; // Initial health of the hero
int monsterHealth = 10; // Initial health of the monster
int attack = 0; // Variable to store the value of each attack
Random dice = new Random(); // Creating a Random object to simulate dice rolls for attack values

do
{
    // Generate a random attack value between 1 and 10 for the hero
    attack = dice.Next(1, 11);
    Console.WriteLine("Attack value is: " + attack);
    
    // Reduce the monster's health by the attack value and display the updated health
    monsterHealth -= attack;
    Console.WriteLine("Monster was damaged and lost " + attack + " health" + 
                      " and now has " + monsterHealth + " health");

    // Generate a random attack value between 1 and 10 for the monster
    attack = dice.Next(1, 11);
    Console.WriteLine("Attack value is: " + attack);

    // Reduce the hero's health by the attack value and display the updated health
    heroHealth -= attack;
    Console.WriteLine("Hero was damaged and lost " + attack + " health" + 
                      " and now has " + heroHealth + " health");
}
// Repeat the loop as long as both hero and monster have health above 0
while (monsterHealth > 0 && heroHealth > 0);

// After the loop, determine and announce the winner
if (heroHealth > monsterHealth)
{
    Console.WriteLine("Hero wins!"); // Hero wins if their health is greater than the monster's
}
else
{
    Console.WriteLine("Monster wins!"); // Monster wins otherwise
}

/*Explanation:
Health Variables: heroHealth and monsterHealth keep track of the current health of the hero and monster.
Random Attack Values: Simulates the randomness of battle attacks using the Random object to generate values between 1 and 10.
Health Reduction: Both the hero and the monster take damage during each iteration of the loop, reducing their health values.
Loop Condition: The do-while loop continues until either the hero's or the monster's health drops to 0 or below.
Winner Determination: After the loop exits, the program checks which character has higher remaining health and declares the winner.*/
