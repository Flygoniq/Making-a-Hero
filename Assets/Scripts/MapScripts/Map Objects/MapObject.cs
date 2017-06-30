using UnityEngine;
using System.Collections;

public class MapObject
{
    //this class is just a container for all objects that go in maps.  The only thing they have in common is that they go in maps
    //However I don't think there is a generic object in unity and I'd rather use this anyway
    //Possible things: Object (wall/char/exit), skit, event trigger.  Map tile might just be split between passable or not, unless it really matters.
    public virtual void Interact () {

    }

    public virtual bool isObstacle() {
        return false;
    }

}
