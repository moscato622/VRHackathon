using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Score : NetworkBehaviour {

    [SyncVar]
    public int score;

    private GameObject OtherPlayer_;
    public GameObject SellectedCube;
    // Use this for initialization
    void Start () {
        score = 0;

    }
	// Update is called once per frame
	void Update () {

        SellectedCube = GameObject.FindGameObjectWithTag("Cube");
            if (SellectedCube.name != "Sellected")
            {
                return;
            }
            else
            {
            Debug.Log("Sellected Ready to get score");
            OtherPlayer_ = GameObject.FindWithTag("OtherPlayer");
                if (OtherPlayer_.GetComponent<SetButtonPress>().pressed)
                {
                Debug.Log("Pressed Ready to get score");
                if (transform.name == "Player1")
                {
                    Debug.Log("Player1 pushs score");
                    CmdPlayerOneSendScore();
                }
                else {
                    Debug.Log("Player2 pushs score");
                    CmdPlayerTwoSendScore();
            } 
         }
      }
    }

    [Command]
    void CmdPlayerOneSendScore()
    {
        score++;
        Debug.Log("Player1 pushed Score");
    }

    [Command]
    void CmdPlayerTwoSendScore()
    {
        Debug.Log("Player2 pushed Score");
        GameObject Player1 = GameObject.Find("Player1");
        Player1.GetComponent<Score>().score ++;
    }
}
