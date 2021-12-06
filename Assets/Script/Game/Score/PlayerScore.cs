using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] GameObject[] number;
    [SerializeField] Transform[] field;
    GameObject[] activeObj;
 
    void Clear()
    {
        for (int i = 0; i < field.Length; i++)
        {
            Destroy(activeObj[i]);
        }
    }

    void SetValue (int score)
    {
        int convert = 1;
        for(int i=0; i < field.Length; i++)
        {
            int scoreConvert = (score / convert) % 10;
            Print(i, scoreConvert, i);
            convert *= 10;
        }
    }

    void Print(int i, int score, int field)
    {
        this.activeObj[i] = Instantiate(this.number[score], this.field[field].position, this.field[field].rotation);
        this.activeObj[i].name = this.field[field].name;
        this.activeObj[i].transform.parent = this.field[field];
    }

    //Start is called before the first frame update
    void Start()
    {
        activeObj = new GameObject[field.Length];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Clear();
        SetValue(FlyBird.playerScore);
    }
    
}