using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CrewManager : MonoBehaviour
{
    public TextMeshProUGUI crewNameText;
    public TextMeshProUGUI hobbyText;
    public GameObject crewPrefab;
    public int crewCount = 10;

    
    public TextDisplay textDisplay;


    public List<string> crewNameList = new List<string>();
    public List<string> crewHobbyList = new List<string>();
    public List<string> parasiteHobbyList = new List<string>();
    public string crewName;
    public string crewHobby;
    public int isParasite;
    

    private Crew CrewCurrentClass;
    private GameObject crewPrefabClone;
    private Crew crewScript;

    public UnityEngine.UI.Button addCrewmateButton;
    public UnityEngine.UI.Button declineCrewmateButton;
    public UnityEngine.UI.Button newCrewmateButton;





    //You have hired 0 crewmates
    //Create new crewmate
    //They have a chance of being a parasite
    //    New Crewmates have a random name from a name pool.
    //Are they a Crewmate?
    //Yes
    //Crewmates have a random favorite hobby
    //No
    //Parasites pick a hobby based on a separate pool


    //Display: Crewmate/Parasite hobby and name
    //Main game loop
    //The player must attempt to determine an applications humanity from their name and hobby

    //Press UI Button

    //Did you hire a crewmate/Parasite?
    //No
    //Create new crewmate
    //Yes
    //Is there 10 crewmates?
    //No
    //Create new crewmate
    //Yes
    //End of game
    //Is there a parasite among the crewmates?
    //Yes
    //Display: There is a parasite
    //Parasite picks a random hobby from one of the crewmates
    //Kills crewmate with that hobby
    //Display: Parasite killed list of names and escaped
    //You lose
    //No
    //Once your 10 crew positions are safely filled with humans, the game is over and you must output your team members names and hobbies.
    //You win

    // Start is called before the first frame update
    // Start is called before the first frame update



    public List<Crew> crewList = new List<Crew>();
    
    void Start()
    {
        newCrewmateButton.enabled = false;
        addCrewmateButton.enabled = false;
        declineCrewmateButton.enabled = false;
        




        NewGame(); 
        
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
       

    
    private void NewGame()
    {
        NewTurn();
    }

    private void NewTurn()
    {
        newCrewmateButton.enabled = true;
        addCrewmateButton.enabled = false;
        declineCrewmateButton.enabled = false;
        
    }
    public void NewCrewmateButtonClick()
    {
        crewPrefabClone = Instantiate(crewPrefab);
        crewScript = crewPrefabClone.GetComponent<Crew>();
        CrewCurrentClass.SpawnCrewPrefab();
        if (crewScript != null)
        {
            crewName = crewScript.GetName();
            crewHobby = crewScript.GetHobby();
        }
        if (textDisplay != null)
        {
            textDisplay.AddNameText(crewName);
            textDisplay.AddHobbyText(crewHobby);
        }
        newCrewmateButton.enabled = false;
        addCrewmateButton.enabled = true;
        declineCrewmateButton.enabled = true;
    }









    public void AddCrewMateCLick()
    {
        declineCrewmateButton.enabled = false;

        if (crewNameList != null)
        { 
        crewNameList.Add(crewName);
            crewHobbyList.Add(crewHobby);

        }
    }




    private void Parasite()
    { 
    isParasite = crewScript.IsParasite();
        if (isParasite >= 1)
        {
            string victimHobby = crewScript.crewHobbyList[UnityEngine.Random.Range(0, crewScript.crewHobbyList.Count)];
        }
    }
}
