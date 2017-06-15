using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    public int Act, Chapter, Scene, Part;
    public int[] SpecialStorage;

    public GameState()
    {
        Act = 1;
        Chapter = 1;
        Scene = 1;
        Part = 1;
        SpecialStorage = new int[5];
    }

    public string ProgressCode()
    {
        return "" + Act + '-' + Chapter + '-' + Scene + '-' + Part;
    }
}
