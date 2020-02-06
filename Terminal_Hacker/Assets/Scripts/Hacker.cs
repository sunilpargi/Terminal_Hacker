using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("");
    }

    void ShowMainMenu()
    {
        Terminal.WriteLine("Hello");
    }
    
    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
        }

        else if(input == "007")
        {
            Terminal.WriteLine("mr.bond enter correct option");
        }
        else
        {
            Terminal.WriteLine("Please choose valid option");
        }
    }
}
