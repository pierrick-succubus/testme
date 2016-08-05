using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

    // Use this for initialization
    public float speed = 1.5f;

	void Start () {
        Debug.Log("Hello World !");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
	}
}
