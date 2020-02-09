using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    enum Screen { Mainmenu, Password, Win };
    Screen currentScreen = Screen.Mainmenu;

    string password;
    string[] level1Passwords = { "Mario", "creed", "Witcher" };
    string[] level2Passwords = { "Tomb", "GhostRecon", "BreakPoint" };
   
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
      
        bool IsvalidNumber = (input == "1" || input == "2");
         if (IsvalidNumber)
        {
            Terminal.ClearScreen();
            level = int.Parse(input);
            Startgame();
        }

       else if (input == "007")
        {
            Terminal.WriteLine("mr.bond Please Enter The correct option");
        }

        else
        {
            Terminal.WriteLine("Please choose valid option");
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


    void Startgame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {
            case 1:
                int index1 = Random.Range(0, level1Passwords.Length);
                password = level1Passwords[index1];
                break;

            case 2:
                int index2 = Random.Range(0, level1Passwords.Length);
                password = level2Passwords[index2];
                break;

            default:Debug.LogError("Invalid number");
                break;

        }
        Terminal.WriteLine("Password:");
    }

    private void CheckPassword(string input)
    {
        if (input == password)
        {

            switch (level)
            {
                case 1:
                       currentScreen = Screen.Win;
                       Terminal.WriteLine("Well Done");
                       Terminal.WriteLine(@"                                                                       
       ______
      /     //
     /     //
    /_____//
   (______(/
                        ");
                       break;

                case 2:
                    currentScreen = Screen.Win;
                    Terminal.WriteLine("You Have Got The Key");
                    Terminal.WriteLine(@"                                                                       
 __  
/0 \_____
\__/-='='                     

                                       ");
                              break;

                default:
                    Debug.LogError("Invalid Password");
                    break;
            } 

        }
         
        

        else
        {
            Terminal.WriteLine("oops wrong password");
        }
    }
}
