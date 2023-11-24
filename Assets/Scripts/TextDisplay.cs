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
    public TextMeshProUGUI crewMurduredText;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNameText(string crewNameAddText)
    {
        crewNameText.text = crewNameAddText;
    }

    public void AddHobbyText(string crewHobbyAddText)
    {
        crewHobbyText.text = crewHobbyAddText;
    }
    public void AddParasiteHobbyText(string parasiteHobbyAddText)
    { 
    parasiteHobbyText.text = parasiteHobbyAddText;
    }


    public void ClearMurderedText(string crewMurderedAddText)
    {
        crewMurduredText.text = crewMurderedAddText;
    }
}
