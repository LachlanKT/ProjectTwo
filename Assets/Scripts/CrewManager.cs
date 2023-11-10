using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CrewManager : MonoBehaviour
{
    public TextMeshProUGUI crewNameText;
    public TextMeshProUGUI hobbyText;
    public GameObject crewPrefab;
    public int crewCount = 10;

    public Transform crewSpawnPoint;
    public float spacing = 2.0f;
    public int isParasite = 0;
    

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

    public List<string> crewNameList = new List<string>();
    public List<string> crewHobbyList = new List<string>();
    public List<string> parasiteHobbyList = new List<string>();

    public List<Crew> crewList = new List<Crew>();
    
    void Start()
    {
        crewNameList.AddRange(new List<string> {"Bob", "Charlie", "Pom"} );
        crewHobbyList.AddRange(new List<string> { "Soccer", "Video Games", "Hockey" });
        parasiteHobbyList.AddRange(new List<string> { "Evil Soccer", "Boring Video Games", "Slippery Hockey" });


        for (int i = 0; i < 3; i++)
        {
            Vector3 spawnPosition = crewSpawnPoint.position + new Vector3(i * spacing, 0, 0);
            SpawnCrewPrefab(spawnPosition);
        }
       

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCrewPrefab(Vector3 position)

    {

        GameObject crewPrefabClone = Instantiate(crewPrefab, position, Quaternion.identity);
        Crew crewScript = crewPrefabClone.GetComponent<Crew>();
        isParasite = UnityEngine.Random.Range(0, 2);
        
        if (crewScript != null)
        {
            crewList.Add(crewScript);
            crewScript.crewName = crewNameList[UnityEngine.Random.Range(0, crewNameList.Count)];


            crewNameList.Remove(crewScript.crewName);
            crewPrefabClone.name = crewScript.crewName;



            if (isParasite == 0)
            {
                crewScript.crewHobby = crewHobbyList[UnityEngine.Random.Range(0, crewHobbyList.Count)];
                crewHobbyList.Remove(crewScript.crewHobby);
            }
            else 
            { 
            crewScript.parasiteHobby = parasiteHobbyList[UnityEngine.Random.Range(0, parasiteHobbyList.Count)];
            }


            
          

        }
        else {
            Debug.Log("No Crew Script found on " + crewPrefabClone.name);
        }
        

    }
}
