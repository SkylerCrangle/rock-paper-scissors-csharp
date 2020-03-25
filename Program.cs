using System;

namespace day2csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //   Console.WriteLine("Hello World!");
      //   string name = "Skyler";
      //   var stringname = "Skyler";
      //   name = "sky";
      //   stringname = "sky";
      //   Console.WriteLine(stringname);
      //   Console.WriteLine(name);
      //   Console.Write(stringname + name);

      var playing = true;
      int scoreYou = 0;
      int scoreMe = 0;
      while (playing)
      {

        Console.WriteLine("Do you want to play a game? y/n");
        var UserInput2 = Console.ReadKey().KeyChar;
        //Console.WriteLine("You said:" + UserInput2);
        if (UserInput2 == 'n')
        {
          playing = false;
        }
        else
        {

          //Console.WriteLine("we are playing still");
          Random rnd = new Random();
          int myRandom = rnd.Next(0, 3);
          // Console.WriteLine(myRandom);
          Console.WriteLine("rock, paper, scissors! r/p/s");
          var input = Console.ReadKey().KeyChar;
          //r = 0
          //p = 1
          //s = 2
          // Console.WriteLine(input);

          switch (input)
          {
            case 'r':
              {
                if (myRandom == 0)
                {
                  Console.WriteLine("You pressed r...and tied");
                  Console.WriteLine("You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                else if (myRandom == 1)
                {
                  scoreMe = scoreMe + 1;
                  Console.WriteLine("You pressed r...and lost (You: " + scoreYou + " Me: " + scoreMe + ")");

                }
                else if (myRandom == 2)
                {
                  scoreYou++;
                  Console.WriteLine("You pressed r... nd won (You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                // Console.WriteLine("You pressed r...");
                break;
              }
            case 'p':
              {
                if (myRandom == 1)
                {
                  Console.WriteLine("You pressed p...and tied");
                  Console.WriteLine("You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                else if (myRandom == 2)
                {
                  scoreMe = scoreMe + 1;
                  Console.WriteLine("You pressed p...and lost (You: " + scoreYou + " Me: " + scoreMe + ")");

                }
                else if (myRandom == 0)
                {
                  scoreYou++;
                  Console.WriteLine("You pressed p... nd won (You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                break;
              }
            case 's':
              {
                if (myRandom == 2)
                {
                  Console.WriteLine("You pressed s...and tied");
                  Console.WriteLine("You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                else if (myRandom == 0)
                {
                  scoreMe = scoreMe + 1;
                  Console.WriteLine("You pressed s...and lost (You: " + scoreYou + " Me: " + scoreMe + ")");

                }
                else if (myRandom == 1)
                {
                  scoreYou++;
                  Console.WriteLine("You pressed s... nd won (You: " + scoreYou + " Me: " + scoreMe + ")");
                }
                break;
              }




          }
        }



      }
    }
  }
}
