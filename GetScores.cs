using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetScores : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player1") != null) {
            Debug.Log("Cube is getting Score from Player1");
            GameObject Player1 = GameObject.Find("Player1");
            transform.GetComponent<Text>().text = Player1.GetComponent<Score>().score.ToString();
        }
	}
}
