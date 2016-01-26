using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

    //value given from editor
    public GameObject prefabToSpawn = null;

    //hold origin of parent
    private Vector3 pOrigin;

    //holds distance to spawn new prefab
    public float spawnDistance = 5f;

    // Use this for initialization
    void Start () {

        //set parent origin
        pOrigin = this.transform.localPosition;
        

	}
	
	// Update is called once per frame
	void Update ()
    {
        //checks distance between current and set origin and whether its moved far
        //enough to spawn a new prefab
        if(Vector3.Distance(pOrigin, this.transform.localPosition) > spawnDistance )
        {
            //spawn a new prefab
            var _spawnedObject = GameObject.Instantiate(prefabToSpawn) as GameObject;
            //setting ourselves to be the parent of the newly spawned object
            _spawnedObject.transform.parent = transform;
            //sets origin to current location at new spawn
            pOrigin = this.transform.localPosition;
        }
	}
}
