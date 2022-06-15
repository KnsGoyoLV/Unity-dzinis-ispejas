using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


    public GameObject[] Levels;
    public GameObject ResetScreen, End;

    public int wrong_res;

    int currentLevel;


    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else if(currentLevel == Levels.Length)
        {
            Levels[currentLevel].SetActive(false);




        }
        else
            wrong_res++;
    }
}
