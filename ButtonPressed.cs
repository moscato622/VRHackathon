using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ButtonPressed : NetworkBehaviour {

    [SyncVar]
    public bool PlayerPressed;
    //public bool buttonIsPressed;
    // Use this for initialization
    void Start() {
        Screen.orientation =  ScreenOrientation.LandscapeLeft;
        PlayerPressed = false;
        //buttonIsPressed = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isLocalPlayer)
            {
                return;
            }
            else {
                PlayerPressed = true;
            }
        }
        else
        {
            if (!isLocalPlayer)
            {
                return;
            }
            else
            {
                PlayerPressed = false;
            }
        }
    }

    //public void buttonPressed() {
    //    buttonIsPressed = true;
    //}
}
