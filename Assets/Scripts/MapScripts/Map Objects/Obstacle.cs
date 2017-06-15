using UnityEngine;
using System.Collections;

public class Obstacle : MapObject
{
    public Obstacle() {

    }

    public override void Interact() {
        //one does not simply interact with an obstacle
    }

    public override bool isObstacle() {
        return true;
    }
}
