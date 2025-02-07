using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;


public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_InputField textInput;
    [SerializeField] private TMP_Text titleText;
    private int randomNum;
    private int lives;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
  
   
   public void UpdateText()
    {
        titleText.text = textInput.text;
    }

    public void GameSetup()
    {
        titleText.text = "Guess The Number";
        randomNum = Random.Range(0, 11);
        lives = 3;
    }

    public void SumbitText()
    {
        if (lives > 0)
        {
            string computNum = randomNum.ToString();
            string livesLeft = lives.ToString();

            if (textInput.text == computNum)
            {
                titleText.text = "You Win!";
                lives = 0;
            }
            else
            {
                titleText.text = "Ahh, you almost got it. You have " + livesLeft + " tries left";
                lives--;
            }
        }
        else
        {
            titleText.text = "You Lose!";
        }

        textInput.text = "";
    }
}
