using UnityEngine;
using System.Collections;

public class TerrainBehavior : MonoBehaviour {
    //Terrain should update it's polygon collider whenever terrain has been added or removed.
    //When Terrain is added where another object lies that isn't terrain, we push it upwards too.


    private PolygonCollider2D bounds;
    private Sprite myimage;
	// Use this for initialization
	void Start () {
        bounds = GetComponent<PolygonCollider2D>();
        myimage = GetComponent<Sprite>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void 
    
}
