using UnityEngine;
using System.Collections;

public class MapScript : MonoBehaviour
{
    public MapObject[,,] mapArray; //let's be good boys and use quadrant one based coordinates, 0,0 in lower left.  3rd stores each map slot's map objects and should be about 4-5 large.
    public int width, height, xcor, ycor, moveCounter;
    public string movement;
    public GameObject character;

    void Awake() {
    }

    public void Initialization() {
        character = GameObject.FindGameObjectWithTag("Player");
        moveCounter = 0;
        movement = "none";
        mapArray = new MapObject[width, height, 4];
    }

    /*public virtual void LoadMap()
    {

    }*/

    public virtual void run() {
        if (movement == "none") {
            if (Input.GetAxisRaw("Vertical") == 1) {
                setMovement("up");
            } else if (Input.GetAxisRaw("Vertical") == -1) {
                setMovement("down");
            } else if (Input.GetAxisRaw("Horizontal") == -1) {
                setMovement("left");
            } else if (Input.GetAxisRaw("Horizontal") == 1) {
                setMovement("right");
            }
        } else {
            move();
        }
    }

    public virtual void setMovement(string direction) {
        Debug.Log("" + xcor + "," + ycor);
        if (movement == "none") {
            if (direction == "up") {
                if (mapArray[xcor, ycor + 1, 0] == null || !mapArray[xcor, ycor + 1, 0].isObstacle()) {
                    if (ycor >= height - 8 || ycor < 7) {
                        movement = "charUp";
                    } else {
                        movement = "up";
                    }
                }
            } else if (direction == "down") {
                if (mapArray[xcor, ycor - 1, 0] == null || !mapArray[xcor, ycor - 1, 0].isObstacle()) {
                    if (ycor > height - 8 || ycor <= 7) {
                        movement = "charDown";
                    } else {
                        movement = "down";
                    }
                }
            } else if (direction == "left") {
                if (mapArray[xcor - 1, ycor, 0] == null || !mapArray[xcor - 1, ycor, 0].isObstacle()) {
                    if (xcor <= 9 || xcor > width - 10) {
                        movement = "charLeft";
                    } else {
                        movement = "left";
                    }
                }
            } else if (direction == "right") {
                if (mapArray[xcor + 1, ycor, 0] == null || !mapArray[xcor + 1, ycor, 0].isObstacle()) {
                    if (xcor < 9 || xcor >= width - 10) {
                        movement = "charRight";
                    } else {
                        movement = "right";
                    }
                }
            }
        }
    }

    public virtual void move() {
        if (movement == "up") {
            if (moveCounter < 20) {
                transform.Translate(new Vector3(0, -2, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                ycor++;
            }
        } else if (movement == "down") {
            if (moveCounter < 20) {
                transform.Translate(new Vector3(0, 2, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                ycor--;
            }

        } else if (movement == "left") {
            if (moveCounter < 20) {
                transform.Translate(new Vector3(2, 0, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                xcor--;
            }

        } else if (movement == "right") {
            if (moveCounter < 20) {
                transform.Translate(new Vector3(-2, 0, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                xcor++;
            }

        } else if (movement == "charUp") {
            if (moveCounter < 20) {
                character.transform.Translate(new Vector3(0, 2, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                ycor++;
            }

        } else if (movement == "charDown") {
            if (moveCounter < 20) {
                character.transform.Translate(new Vector3(0, -2, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                ycor--;
            }

        } else if (movement == "charLeft") {
            if (moveCounter < 20) {
                character.transform.Translate(new Vector3(-2, 0, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                xcor--;
            }

        } else if (movement == "charRight") {
            if (moveCounter < 20) {
                character.transform.Translate(new Vector3(2, 0, 0));
                moveCounter++;
            } else {
                movement = "none";
                moveCounter = 0;
                xcor++;
            }

        }
    }
}
