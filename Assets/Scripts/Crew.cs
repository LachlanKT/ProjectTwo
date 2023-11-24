using System.Buffers.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Crew : MonoBehaviour
{
    public int isParasite = 0;
    //Initialize variables

    public string crewHobby = "crewHobby";
    public string parasiteHobby = "parasiteHobby";
    public string crewName = "crewName";



    public List<string> crewNameList = new List<string>();
    public List<string> crewHobbyList = new List<string>();
    public List<string> parasiteHobbyList = new List<string>();

    




void Start()
    {
        crewNameList.AddRange(new List<string> { "Bob", "Charlie", "Pom" });
        crewHobbyList.AddRange(new List<string> { "Soccer", "Video Games", "Hockey" });
        parasiteHobbyList.AddRange(new List<string> { "Evil Soccer", "Boring Video Games", "Slippery Hockey" });
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void SpawnCrewPrefab()

    //{
    //    if (crewScript != null)
    //    {
    //        crewList.Add(crewScript);
    //        crewScript.crewName = crewNameList[UnityEngine.Random.Range(0, crewNameList.Count)];


    //        crewNameList.Remove(crewScript.crewName);
    //        crewPrefabClone.name = crewScript.crewName;



    //        if (isParasite == 0)
    //        {
    //            crewScript.crewHobby = crewHobbyList[UnityEngine.Random.Range(0, crewHobbyList.Count)];
    //            crewHobbyList.Remove(crewScript.crewHobby);
    //        }
    //        else
    //        {
    //            crewScript.crewHobby = parasiteHobbyList[UnityEngine.Random.Range(0, parasiteHobbyList.Count)];
    //        }





    //    }
    //    else
    //    {
    //        Debug.Log("No Crew Script found on " + crewPrefabClone.name);
    //    }
    //}



public void SpawnCrewPrefab() 
    {
        string myName;
        myName = crewNameList[UnityEngine.Random.Range(0, crewNameList.Count)];
        String myHobby;
        isParasite = UnityEngine.Random.Range(0, 2);
        if (isParasite == 0)
        {
            myHobby = crewHobbyList[UnityEngine.Random.Range(0, crewHobbyList.Count)];
          
        }
        else
        {
            myHobby = parasiteHobbyList[UnityEngine.Random.Range(0, crewHobbyList.Count)];
        }
        crewName = myName;
        crewHobby = myHobby;
        Debug.Log(crewName + " with " + crewHobby + " just made in my Crew.cs.");
    }
    public string GetName()
    {
        return crewName;
    }
    public string GetHobby()
    {
        return crewHobby;
    }

    public int IsParasite()
    {
        return isParasite;
    }

    //public void Ejected()
    //{
    //    CrewTextDisplay crewTextDisplay = FindObjectOfType<CrewTextDisplay>();
    //    crewTextDisplay.ClearcrewListText();

    //if (gameObject != null)
    //{
    //    Destroy(gameObject);
    //    return;
            
    //        }
    //}


}
