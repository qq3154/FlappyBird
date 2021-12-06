using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Changemedal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Image bronzeMedal;
    public Sprite silverMedal;
    public Sprite goldMedal;


    private void Update()
    {
        if(FlyBird.playerScore > 5)
        {
            bronzeMedal.sprite = silverMedal;
        }
        if (FlyBird.playerScore > 10)
        {
            bronzeMedal.sprite = goldMedal;
        }

    }
}
