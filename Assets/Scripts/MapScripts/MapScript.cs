using UnityEngine;
using System.Collections;

public class MapScript : MonoBehaviour
{
    public MapObject[,,] mapArray; //let's be good boys and use quadrant one based coordinates, 0,0 in lower left.  3rd stores each map slot's map objects and should be about 4-5 large.
    public int xcor, ycor;
    public string movement;

    /*public virtual void LoadMap()
    {

    }*/

    public virtual void run() {

    }
}
