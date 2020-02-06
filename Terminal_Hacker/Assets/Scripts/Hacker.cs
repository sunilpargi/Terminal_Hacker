using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    enum Screen { Mainmenu, Password, Win };
    Screen currentScreen = Screen.Mainmenu;
   
    void Start()
    {
        ShowMainMenu();
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
    
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }

        else if(input == "007")
        {
            Terminal.WriteLine("mr.bond Please Enter The correct option");
        }

        else if (input == "1")
        {
            level = 1;
            Startgame();
        }

        else if(input == "2")
        {
            level = 2;
            Startgame();
        }


        else
        {
            Terminal.WriteLine("Please choose valid option");
        }
    }

    void Startgame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You Have Chosen:" + level);
    }
}
