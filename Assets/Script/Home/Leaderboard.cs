using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] GameObject obj;
    

 
 
    
    // Start is called before the first frame update
    void Start()
    {
        int[] score = new int[5];
        score[1] = PlayerPrefs.GetInt("highScore1");
        score[2] = PlayerPrefs.GetInt("highScore2");
        score[3] = PlayerPrefs.GetInt("highScore3");
        score[4] = FlyBird.playerScore;
        for (int i = 3; i > 0; i--)
        {
            if (score[i] < score[i + 1])
            {
                int tmp = score[i];
                score[i] = score[i + 1];
                score[i + 1] = tmp;
            }
        }

        for (int i = 1; i < 4; i++)
        {
           

            GameObject child = obj.transform.GetChild(i).gameObject;
            child.GetComponent<Text>().text = score[i].ToString();
            
            PlayerPrefs.SetInt("highScore1", score[1]);
            PlayerPrefs.SetInt("highScore2", score[2]);
            PlayerPrefs.SetInt("highScore3", score[3]);
            PlayerPrefs.Save();

        }
        /*
        PlayerPrefs.SetInt("highScore1", 0);
        PlayerPrefs.SetInt("highScore2", 0);
        PlayerPrefs.SetInt("highScore3", 0);
        PlayerPrefs.Save();
        */
    }


}
