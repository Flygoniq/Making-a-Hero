using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCheckerboardScript : MapScript {
    //40 x 30 map


	// Use this for initialization
	void Awake () {
        width = 40;
        height = 30;
        Initialization();
        xcor = 1;
        ycor = 1;
        transform.position = new Vector3(420, 300, 0);
        for (int i = 0; i < width; i++)
        {
            mapArray[i, 0, 0] = new Obstacle();
            mapArray[i,height - 1,0] = new Obstacle();
        }
        for (int i = 1; i < height - 1; i++) {
            mapArray[0,i,0] = new Obstacle();
            mapArray[width - 1,i,0] = new Obstacle();
        }
    }
    
    public override void run() {
        base.run();
    }
}
