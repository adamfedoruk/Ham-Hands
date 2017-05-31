using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public Rigidbody bullet;
	public float power = 500f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Fire a projectile when fire button is pushed
		if (Input.GetButtonUp ("Fire1")) {
			Rigidbody instance = 
				Instantiate (bullet, transform.position + new Vector3(0,0, 0.75f), transform.rotation) as Rigidbody;
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			instance.AddForce (fwd * power);
		}
	}
}
