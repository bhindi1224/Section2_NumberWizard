using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

        int max;
        int min;
        int guess;

	// Use this for initialization
	void Start ()
    {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard.");
        Debug.Log("Pick a number between " + min + " and " + max + ".");
        Debug.Log("Tell me if your number is higher or lower than " + guess + ".");
        Debug.Log("Press the following key to respond:");
        Debug.Log("   Up Arrow if your number is higher,");
        Debug.Log("   Down Arrow if your number is lower,");
        Debug.Log("   Enter if I guessed correctly.");
        max += 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Ok, my guess was too low.");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Alright, my guess was too high.");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Great, I knew your number was " + guess + " all along!");
            StartGame();
        }
    }

    void NextGuess()
    {
            guess = (max + min) / 2;
            Debug.Log("Is your number " + guess + "?");
    }
}
