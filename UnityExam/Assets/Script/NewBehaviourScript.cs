using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


    public GameObject[] Levels;
    public GameObject End;

    public int wrong_res;

    int currentLevel;


    public void wrongAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);
            currentLevel++;
            Levels[currentLevel].SetActive(true);

            wrong_res++;
        }
        else
        {
            Levels[currentLevel].SetActive(false);
            End.SetActive(true);



        }

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
        else
        {
            Levels[currentLevel].SetActive(false);
            End.SetActive(true);



        }
    }


    public Text ValueText;

    void Update()
    {
        ValueText.text = wrong_res.ToString();
    }




}
