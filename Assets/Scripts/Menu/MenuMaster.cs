using UnityEngine;
using System.Collections;

public class MenuMaster : MonoBehaviour
{
    public static int SaveSlot;

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        Screen.SetResolution(760, 600, false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
