using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CheckOtherPlayerButtonPress : NetworkBehaviour {

    public Vector3 OriSize;
    private bool otherHeadSetButtonPress;
    // Use this for initialization
    void Start () {

        OriSize = transform.localScale;
        otherHeadSetButtonPress = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }
        else {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject PlayerObj in players) {
                if (PlayerObj.name == transform.name)
                {
                    return;
                }
                else {
                    otherHeadSetButtonPress = PlayerObj.GetComponent<ButtonPressed>().PlayerPressed;
                }
            }
            
        }

        if (!otherHeadSetButtonPress)
        {
            transform.localScale = OriSize;
        }
        else
        {
            transform.localScale = OriSize * 2f;
        }
    }
}
