using UnityEngine;
using System.Collections;

public class MoveChild : MonoBehaviour {

    // movement speed
    public float moveSpeed = 0.5f;
    // furthest distance
    public float maxDistance = 5f;
    // closest distance
    public float minDistance = 0f;

	// Use this for initialization
	void Start () {
	    
	}

    /// <summary>
    /// Used to update the position of the child once per frame
    /// Used http://answers.unity3d.com/answers/690948/view.html 
    /// to decide on method to use
    /// </summary>
    // Update is called once per frame
    void Update () {
        //holds lower limit position
        Vector2 pos1 = new Vector2(minDistance, 0);
        //holds upper limit position
        Vector2 pos2 = new Vector2(maxDistance, 0);
        //moves the child back and forth between the two position
        transform.localPosition = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * moveSpeed, 1f));     
	}
}
