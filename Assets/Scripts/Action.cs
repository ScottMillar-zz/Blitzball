using UnityEngine;
using System.Collections;

public class Action : MonoBehaviour {

    bool showMenu = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Escape))
        {
            if(showMenu == false)
            {
                showMenu = true;
            }
            else
            {
                showMenu = false;
            }
        }
	}
}
