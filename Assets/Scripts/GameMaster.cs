using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    //MenuMaster menuMaster;
    string window; //record current window.  localmap, for example.
    public static GameState gameState;
    public GameObject[] maps;
    public GameObject[] characters;
    GameObject currentMap;
    MapScript currentMapScript;

	// Use this for initialization
	void Awake () {
        //menuMaster = GameObject.FindGameObjectWithTag("MenuMaster").GetComponent<MenuMaster>();
        gameState = new GameState();
        if (MenuMaster.SaveSlot == -1)
        {
            window = "localmap";
            currentMap = Instantiate(maps[0], new Vector3(0, 0, 0), Quaternion.identity);
            currentMapScript = currentMap.GetComponent<MapScript>();
            Instantiate(characters[0], new Vector3(0, 0, 0), Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {
		if (window == "localmap") {
            currentMapScript.run();
        }
	}

    void LoadMap(GameObject map) //good chance this will need more parameter or an overloaded version with more parameters such as where player enters... or just put player on map based on current location.
    {

    }
}
