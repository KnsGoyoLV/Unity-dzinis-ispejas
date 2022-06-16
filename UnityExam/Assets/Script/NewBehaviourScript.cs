using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    //Definējam līmeni uz kura esam un rezultātu
    public GameObject[] Levels;
    public GameObject End;
    int wrong_res;
    int right_res;
    int currentLevel;
    

    public void wrongAnswer()
    {
        //Pārbaudam vai tagadnejais līmens nebūs lielāks nekā vispārīgi ir atļauts,
        //Ja nav parbaudīts tad tas var izraisīt error
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);//Paslēpjam tagadnējo līmeni
            currentLevel++;//Pārejam uz nakamo līmeni
            Levels[currentLevel].SetActive(true);//Parādam līmeni

            wrong_res++;//Pieskaitam nepareizo atbildi
        }
        else
        {
            Levels[currentLevel].SetActive(false);//Paslēpjam tagadnējo līmeni
            wrong_res++;//Pieskaitam nepareizo atbildi
            End.SetActive(true);//Parādam beigu ekrānu
        }

    }
    public void correctAnswer()
    {
        //Pārbaudam vai tagadnejais līmens nebūs lielāks nekā vispārīgi ir atļauts,
        //Ja nav parbaudīts tad tas var izraisīt error
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);//Paslēpjam tagadnējo līmeni

            currentLevel++;//Pārejam uz nakamo līmeni
            Levels[currentLevel].SetActive(true);//Parādam līmeni
            right_res++;//Pieskaitam pareizo atbildi
        }
        else
        {
            Levels[currentLevel].SetActive(false);//Paslēpjam tagadnējo līmeni
            End.SetActive(true);//Parādam beigu ekrānu
            right_res++;//Pieskaitam pareizo atbildi

        }
    }

    //Definējam rezultāta tekstu 
    public Text WrongText;
    public Text RightText;
    void Update()
    {
        //Pārveidojam int uz string lai varētu printēt rezultātu
        WrongText.text = wrong_res.ToString();
        RightText.text = right_res.ToString();

    }




}
