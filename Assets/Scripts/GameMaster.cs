using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    //MenuMaster menuMaster;
    string state; //record what is being run atm.  localmap, for example.
    public static GameState gameState;
    GameObject currentMap;
    MapScript currentMapScript;
    public bool testing;

    float timer;
    int counter;

	// Use this for initialization
	void Awake () {
        //menuMaster = GameObject.FindGameObjectWithTag("MenuMaster").GetComponent<MenuMaster>();
        gameState = new GameState();
        if (testing || MenuMaster.SaveSlot == -1)
        {
            state = "localmap";
            Instantiate(Resources.Load("Sprites/Character/TestSprite"), new Vector3(-320, -240, -1), Quaternion.identity);
            currentMap = (GameObject)Instantiate(Resources.Load("Maps/Big Checkerboard"), new Vector3(0, 0, 0), Quaternion.identity);
            currentMapScript = currentMap.GetComponent<MapScript>();
        }
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
		if (state == "localmap") {
            currentMapScript.run();
        }
	}

    void LoadMap(GameObject map) //good chance this will need more parameter or an overloaded version with more parameters such as where player enters... or just put player on map based on current location.
    {

    }
}
