using System.ComponentModel;

int heroHealth = 10;
int monsterHealth = 10;
int attack = 0;
Random dice = new Random();

do 
{
    
    attack = dice.Next(1,11);
    Console.WriteLine("Attack value is: " + attack);
    monsterHealth -= attack;
    Console.WriteLine("Monster was damaged and lost " + attack + " health" + " and now has " + monsterHealth + " health");
    
    attack = dice.Next(1,11);
    heroHealth -= attack;
    Console.WriteLine("Attack value is: " + attack);
    Console.WriteLine("Hero was damaged and lost " + attack + " health" + " and now has " + monsterHealth + " health");
}
while (monsterHealth > 0 && heroHealth > 0);

if (heroHealth > monsterHealth){
    Console.WriteLine("Hero wins!");
}
else{
    Console.WriteLine("Monster wins!");
}