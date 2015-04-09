using UnityEngine;
using System.Collections;

public class TriggerDoor : MonoBehaviour {

	private HingeJoint hinge;

	// Use this for initialization
	void Start () {
		hinge = GetComponentInChildren<HingeJoint> ();
	}

	void OnTriggerEnter (Collider other) {
		JointSpring spring;

		spring = hinge.spring;
		spring.targetPosition = 90f;
		hinge.spring = spring;
	}

	void OnTriggerExit (Collider other) {
		JointSpring spring;

		spring = hinge.spring;
		spring.targetPosition = 0f;
		hinge.spring = spring;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
