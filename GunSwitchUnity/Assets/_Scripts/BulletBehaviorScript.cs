using UnityEngine;
using System.Collections;

public class BulletBehaviorScript : MonoBehaviour {
    public float _DamageRatio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float DamageDivision()
    {
        return _DamageRatio;
    }
}
