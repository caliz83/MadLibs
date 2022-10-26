// Mauricio review, good job!


string noun1;
string verb1;
string noun2;
string day1;
string noun3;
string location1;
string verb2;
string verb3;
string noun4;
string verb4;
string playAgain = "Y";


while (playAgain != "N"){
    //string [] Prompts = {"noun", "past tense verb", "noun", "day of week", "noun", "location", "past tense verb", "past tense verb", "noun", "verb"};
    //string.Empty [] Words = {}
    //Console.WriteLine("Please pick a " + Prompts[0] + ".");
    //Words [0] = Console.ReadLine();

    Console.WriteLine("Please pick a noun.");
    //Console.WriteLine("Please pick a " + Prompts[0] + ".");
    noun1 = Console.ReadLine();
    Console.WriteLine("Now pick a past tense verb.");
    //Console.WriteLine("Please pick a " + Prompts[1] + ".");
    verb1 = Console.ReadLine();
    Console.WriteLine("Now pick another noun.");
    //Console.WriteLine("Please pick a " + Prompts[2] + ".");
    noun2 = Console.ReadLine();
    Console.WriteLine("Now pick a day of the week.");
    //Console.WriteLine("Please pick a " + Prompts[3] + ".");
    day1 = Console.ReadLine();
    Console.WriteLine("Now pick another noun.");
    //Console.WriteLine("Please pick a " + Prompts[4] + ".");
    noun3 = Console.ReadLine();
    Console.WriteLine("Now pick a location");
    //Console.WriteLine("Please pick a " + Prompts[5] + ".");
    location1 = Console.ReadLine();
    Console.WriteLine("Now pick a past tense verb.");
    //Console.WriteLine("Please pick a " + Prompts[6] + ".");
    verb2 = Console.ReadLine();
    Console.WriteLine("Now pick a past tense verb.");
    //Console.WriteLine("Please pick a " + Prompts[7] + ".");
    verb3 = Console.ReadLine();
    Console.WriteLine("Now pick a noun.");
    //Console.WriteLine("Please pick a " + Prompts[8] + ".");
    noun4 = Console.ReadLine();
    Console.WriteLine("Now pick a verb.");
    verb4 = Console.ReadLine();

    Console.WriteLine("Once upon a time there was a " + noun1 + " named Jeff. Jeff " + verb1 + " to " + noun2 + " one " + day1 + ". When he got there the " + noun3 + " told him he was late and to go sit in the " + location1 + ". Jeff " + verb2 + " 'That's not fair!' and " + verb3 + " out the " + noun4 + ". His dad made him " + verb4 + " the next day.");

   
    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();

    
 
}
Console.WriteLine("Whatever. Bye!");