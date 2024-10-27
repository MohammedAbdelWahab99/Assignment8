using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // Exercise 1: Number Generator:

        Debug.Log("Welcome...");
        while(true){
            int randomNum = Random.Range(1,21);
            if(randomNum == 5){ 
                continue;
                Debug.Log(randomNum);
            }
            else if(randomNum == 15){
                Debug.Log(randomNum);
                break;
            }
            else{
                Debug.Log(randomNum);
            }
        }

        // Exercise 2: Funny Sentence Generator:

            string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "tree", "Monkey", "Ball", "Bird"};
            int counter = 0;
            while(counter < 7){
                string sentence= "";
                int index = Random.Range(0,9);
                sentence += words[index];
                Debug.Log(sentence);
                counter++;
            }
    }
}