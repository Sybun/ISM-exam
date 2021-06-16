using System;
class HelloWorld {
  static void Main() {
    string userInputString = Console.ReadLine();
    float userInputFloat = float.Parse(userInputString);
    int userInputInt = (int)Math.Round(userInputFloat * 100);
    int counter = 0;
    
while(userInputInt > 0)
{
    if(userInputInt >= 25)
    {
        counter = counter + 1;
        userInputInt= userInputInt - 25;
    }
    else if(userInputInt >= 10)
    {
        counter = counter + 1;
        userInputInt= userInputInt - 10;
    }
    else if(userInputInt >= 5)
    {
        counter = counter + 1;
        userInputInt= userInputInt - 5 ;
    }
    else if(userInputInt >= 1)
    {
        counter = counter + 1;
        userInputInt= userInputInt - 1;
    }
}
    
    
    Console.WriteLine(counter);
  }
}
