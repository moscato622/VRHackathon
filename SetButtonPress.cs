using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetButtonPress : NetworkBehaviour {

    [SyncVar]
    public bool pressed;

    //[SyncVar]
    //public int score = 0;

    private GameObject OtherPlayer_;
    //private GameObject SellectedCube;

    private bool was = false;
    

	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        /*SellectedCube = GameObject.FindWithTag("Cube");
        if (SellectedCube.name != "Sellected") {
            return;
        }
        else
        {
            OtherPlayer_ = GameObject.FindWithTag("OtherPlayer");
            if (OtherPlayer_.GetComponent<SetButtonPress>().pressed) {
                CmdGetScore();
            }
        }*/
        if (isLocalPlayer)
        {
            if (Input.GetMouseButtonDown(0))
            {
                pressed = true;

                Debug.Log("Button Pressed");
            }
            else
            {
                pressed = false;
            }
            
            if (pressed != was)
            {
                CmdButtonIsPressed(pressed);
            }
            was = pressed;
        }

        
    }

    [Command]
    void CmdButtonIsPressed(bool isPressed)
    {
        pressed = isPressed;
    }

    /*[Command]
    void CmdGetScore()
    {
        score++;
    }

    void OnGUI()
    {

        GUI.Box(new Rect(Screen.width / 2, Screen.height * 3 / 4, Screen.width / 5, Screen.height / 5), score.ToString());

    }*/

}
