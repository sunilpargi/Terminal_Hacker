using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    enum Screen { Mainmenu, Password, Win };
    Screen currentScreen = Screen.Mainmenu;

    string password;
    string[] level1Passwords = { "book", "pen", "table" };
    string[] level2Passwords = { "gun", "danger", "savior" };
    string[] level3Passwords = { "space", "starwars", "galaxy" };

    string menuType = "You may type menu at any time";
   
    void Start()
    {
        ShowMainMenu();
    }

   
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            currentScreen = Screen.Mainmenu;
            ShowMainMenu();
        }

        else if(input == "quit" || input == "close"|| input == "exit")
        {
            Application.Quit();
        }

        else if(currentScreen == Screen.Mainmenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    private void RunMainMenu(string input)
    {
      
        bool IsvalidNumber = (input == "1" || input == "2" || input == "3");
         if (IsvalidNumber)
        {
            Terminal.ClearScreen();
            level = int.Parse(input);
            AskForPassword();
        }

       else if (input == "007")
        {
            Terminal.WriteLine("mr.bond Please Enter The correct option");
        }

        else
        {
            Terminal.WriteLine("Please choose valid option");
            Terminal.WriteLine(menuType);

        }
    }
   

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello");
        Terminal.WriteLine("What Would you like to hack into");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the Police");
        Terminal.WriteLine("Press 3 for the Nasa");
    }


    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("Enter your Password:" + password.Anagram());
        Terminal.WriteLine(menuType);
    }

    private void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                int index1 = Random.Range(0, level1Passwords.Length);
                password = level1Passwords[index1];
                break;

            case 2:
                int index2 = Random.Range(0, level2Passwords.Length);
                password = level2Passwords[index2];
                break;

            case 3:
                int index3 = Random.Range(0, level3Passwords.Length);
                password = level3Passwords[index3];
                break;

            default:
                Debug.LogError("Invalid number");
                break;

        }
    }

    private void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        switch (level)
        {
            case 1:
                currentScreen = Screen.Win;
                Terminal.WriteLine("Well Done you have got the book");
                Terminal.WriteLine("Play Again for greater challanges");
                Terminal.WriteLine(@"                                                                       
       ______
      /     //
     /     //
    /_____//
   (______(/
                        ");
              
                Terminal.WriteLine(menuType);
                break;

            case 2:
                currentScreen = Screen.Win;
                Terminal.WriteLine("You Have Got The Key");
                Terminal.WriteLine("Play Again for greater challanges");
                Terminal.WriteLine(@"                                                                       
 __  
/0 \_____
\__/-='='                     

                                       ");
              
                Terminal.WriteLine(menuType);
                break;

            case 3:
                currentScreen = Screen.Win;

                Terminal.WriteLine("Welcome to the Nasa");
                Terminal.WriteLine("Play Again for greater challanges");
                Terminal.WriteLine(@"     
___    __        ______
| |\  | |   /\   ||   |   /\
| | \ | |  /__\    \\    /__\
|_|  \__| /    \ |___|| /    \



                                       ");
               
              
                Terminal.WriteLine(menuType);
                break;


            default:
                Debug.LogError("Invalid Password");
                break;
        }
    }
}
