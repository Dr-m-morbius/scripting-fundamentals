using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class varibles : MonoBehaviour
{
    public int Score = 0; //declare whole number
    public float ItemAmount = 19.95f; //declare a decimal number
    public string PlayerName = "The_Rizzler";//declare a text
    public bool IsPlayerActive = true;// declare a true/false

    // Start is called before the first frame update
    private int _collectibleAmount = 0;
    private float _horizontalInput = 0f;
    private string _username = "The_Rizzalanty";
    private bool _isGameOver = false;

    void Start()
    {
        //make sure score is =0
        Score = 0; // assigning a global/member varible

        // declare a local variable to track start position
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //trying to update a local varible
        //we cannot update a local varible
        //startPosition = new Vector3(Vector3.right);

        //creat a varible to determine object key move
        float verticalInput = Input.GetAxis("Vertical");
    }
}
