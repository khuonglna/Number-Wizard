using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    // Start is called before the first frame update
    int max;
    int min;
    int guess;
    void Start() {
        StartGame();   
    }
    
    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("I'm gonna read your mind");
        Debug.Log("Pick a number");
        Debug.Log("Highest: " + max);
        Debug.Log("Lowest: " + min);
        Debug.Log("Higher or Lower than " + guess);
        Debug.Log("Up arrow = Higher, Down arrow = Lower, Enter = Correct");
        max += 1;
    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log(guess);
        Debug.Log("Higer or Lower than " + guess + "?");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Nailed it");
            StartGame();
        }
    }   
}
