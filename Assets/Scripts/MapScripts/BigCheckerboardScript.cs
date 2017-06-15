using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCheckerboardScript : MapScript {
    //40 x 30 map


	// Use this for initialization
	void Awake () {
        xcor = 1;
        ycor = 1;
        movement = "none";
        transform.position = new Vector3(740, 540, 0);
        mapArray = new MapObject[40, 30, 4];
        for (int i = 0; i < 40; i++)
        {
            mapArray[i, 0, 0] = new Obstacle();
            mapArray[i,29,0] = new Obstacle();
        }
        for (int i = 1; i < 29; i++) {
            mapArray[0,i,0] = new Obstacle();
            mapArray[39,i,0] = new Obstacle();
        }
    }
    
    public override void run() {
        if (movement == "none") {
            if (Input.GetAxisRaw("Vertical") == 1) {
                if (mapArray[xcor, ycor + 1, 0] == null || !mapArray[xcor, ycor + 1, 0].isObstacle()) {
                    movement = "up";
                }
            } else if (Input.GetAxisRaw("Vertical") == -1) {
                if (mapArray[xcor, ycor - 1, 0] == null || !mapArray[xcor, ycor - 1, 0].isObstacle()) {
                    movement = "down";
                }
            } else if (Input.GetAxisRaw("Horizontal") == -1) {
                if (mapArray[xcor - 1, ycor, 0] == null || !mapArray[xcor - 1, ycor, 0].isObstacle()) {
                    movement = "left";
                }
            } else if (Input.GetAxisRaw("Horizontal") == 1) {
                if (mapArray[xcor + 1, ycor, 0] == null || !mapArray[xcor + 1, ycor, 0].isObstacle()) {
                    movement = "right";
                }
            }
        } else if (movement == "up") {

        } else if (movement == "down") {

        } else if (movement == "left") {

        } else if (movement == "right") {

        }
    }
}
