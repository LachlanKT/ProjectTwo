using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI crewNameText;
    public TextMeshProUGUI crewHobbyText;
    public TextMeshProUGUI parasiteHobbyText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddText(string textToAdd)
    { 
    crewNameText.text = textToAdd;
    }
}
