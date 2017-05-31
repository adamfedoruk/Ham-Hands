using UnityEngine;
using System.Collections;

public class PickUpObjects : MonoBehaviour {

	GameObject hitObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			RaycastHit hit;

			//Cast a ray
			//Debug.DrawRay(gameObject.transform.position, transform.forward, Color.red, 5);
			if (Physics.Raycast (transform.position, transform.forward, out hit, 3)) {
				hitObject = hit.collider.gameObject;
				hitObject.transform.parent = gameObject.transform;
			}
		} else if (Input.GetButtonUp ("Fire2")) {
			hitObject.transform.parent = null;
			hitObject = null;
		}

	}
}
