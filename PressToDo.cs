using UnityEngine;
using System.Collections;

public class PressToDo : MonoBehaviour {

    public Transform StartPoint;
    private GameObject OtherPlayer_;
    float step = Time.deltaTime * 1.0f;
    float shakeSize;
    Vector3 direction;
    
    float distance = 0f;

    // Use this for initialization
    void Start () {
        transform.position = StartPoint.position;
        //direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);

    }
	
	// Update is called once per frame
	void Update () {
        OtherPlayer_ = GameObject.FindWithTag("OtherPlayer");
        //float speed = 1.5f;
        if (OtherPlayer_ != null)
        {
            if (OtherPlayer_.GetComponent<SetButtonPress>().pressed)
            {
                
                Debug.Log("Other Button Pressed");
                if (transform.name == "Sellected")
                {
                    shakeSize = 1f;
                    direction = Random.onUnitSphere;
                    //direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
                    distance = 2 * Random.value + 1.5f;
                    //Debug.Log("direction.x " + direction.x + " direction.y " + direction.y + " direction.z " + direction.z + " distance " + distance);
                    //transform.localPosition = Vector3.MoveTowards(transform.position, direction * distance, step);
                   
                    //transform.localPosition = direction * distance;
                }

            }
        }
        transform.localPosition = Vector3.Slerp(transform.localPosition, -direction * distance, step);
        if (shakeSize > 0f) {
            shakeSize -= 0.1f;
        }
        transform.Rotate(0f,0f,Mathf.Sin(Time.deltaTime) * shakeSize);



    }

    public void PressedButton()
    {
        if (transform.name == "Sellected")
        {

            Vector3 direction = Random.onUnitSphere;
            direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
            float distance = 2 * Random.value + 1.5f;
            transform.localPosition = direction * distance;
        }
    }

    public void TeleportRandomly()
    {
        Vector3 direction = Random.onUnitSphere;
        direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
        float distance = 2 * Random.value + 1.5f;
        transform.localPosition = direction * distance;

    }
}
