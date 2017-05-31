using UnityEngine;
using System.Collections;

public class GoToTarget : MonoBehaviour {

	GameObject target;

	private UnityEngine.AI.NavMeshAgent nma;

	// Use this for initialization
	void Start () {
		nma = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		target = GameObject.Find ("TrafficDestination1");
	}
	
	// Update is called once per frame
	void Update () {
		nma.SetDestination (target.transform.position);
		if (nma.transform.position == target.transform.position)
			Destroy (gameObject);
	}

	// function for pressing navigate button
	// will cause the object attached to seek out the target object
	public void navigatePressed() {
		nma.SetDestination (target.transform.position);
	}
}
