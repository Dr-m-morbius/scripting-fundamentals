using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallengec : MonoBehaviour
{
    public int score = 0;
    public string PlayerName = "Morghan";
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increseScore()
    {
        score = score + 10;
    }
    public void PrintPlayerName()
    {
       Debug.Log("Morghan");
    }
    public void Decresehealth()
    {
        health = health - 20;
    }
}
