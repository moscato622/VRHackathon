using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ShowIpAddress : NetworkBehaviour {

    void OnGUI() {

        GUI.Box(new Rect(Screen.width / 2, Screen.height * 3 / 4, Screen.width / 5, Screen.height / 5), Network.player.ipAddress.ToString());

    }
    void Update() {
        Destroy(this,5f);
    }
}
