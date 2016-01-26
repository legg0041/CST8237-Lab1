using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    //angle to rotate
    public float angle = 3f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //rotates the gameobject at the set angle
        this.transform.Rotate(0, 0 , angle);
	}
}
