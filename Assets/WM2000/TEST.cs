using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen = Screen.MainMenu;

    // Use this for initialization
    void Start () {
        
        ShowMainMenu();
        print("hello user");

    }
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("PRESS 1 FOR EASY");
        Terminal.WriteLine("PRESS 2 FOR MEDIUM");
        Terminal.WriteLine("ENTER YOU SELECTION: ");

    }
   
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);

        }


    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("choose a valid option");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("you have choosen level " + level);
        Terminal.WriteLine("enter your password");
    }
	
}
