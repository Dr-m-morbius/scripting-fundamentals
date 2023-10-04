using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class functionsandmethods : MonoBehaviour
{
    private int _playerHealthAmount = 100;
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method examples

    //this method is accesable from other files becuase its public
    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;
    }


    //this method is not assecable from other files
    private void OnBecameInvisible()
    {
        Score++; //score = score + 1
    }

    private void MovePlayer() 
    {
        transform.Translate(Vector3.forward);
    }
}

  
