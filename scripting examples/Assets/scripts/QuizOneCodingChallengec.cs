using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallengec : MonoBehaviour
{
    public int Score = 0;
    public string PlayerName = "Morghan";
    public int Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        IncreseScore();
        PrintPlayerName();
        Decresehealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void IncreseScore()
    {
        Score = Score + 10;
   
    }
    private void PrintPlayerName()
    {
       Debug.Log("PlayerName");
    }
    private void Decresehealth()
    {
        Health = Health - 20;
    }
}
