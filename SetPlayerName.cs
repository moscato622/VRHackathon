using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetPlayerName : NetworkBehaviour {

	// Use this for initialization
	void Start () {
        if (!isServer)
        {
            if (!isLocalPlayer) {
                transform.name = "Player 1";
                transform.tag = "OtherPlayer";
            } else {
                transform.name = "Player 2";
                transform.tag = "localPlayer";
            }
            
        }
        else {
            if (!isLocalPlayer)
            {
                transform.name = "Player 2";
                transform.tag = "OtherPlayer";
            }
            else
            {
                transform.name = "Player 1";
                transform.tag = "localPlayer";
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
