using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UiManager : MonoBehaviour
{

    public  int coinNumber=0;
    public Text textCount;
    void Start()
    {
        textCount = GetComponent<Text>();
    }

    void Update()
    {
        textCount.text = "Coin : " + coinNumber;
        Debug.Log("he");
    }
        
    
}
