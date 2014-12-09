using UnityEngine;
using System.Collections;

public class FacePlayer : MonoBehaviour {

	public GameObject target;
	public Vector2 lookAtPlayerDistance;

	private Quaternion defaultAngle;
	private bool isLookingAtPlayer = false;
	private Transform targetTransform;

	void Awake() {
		targetTransform = target.GetComponent<Transform>();  //Gets the players transform immediatly to not have to getComponent each frame
		defaultAngle = transform.rotation;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckForPlayer();
	}

	void CheckForPlayer() {
		Vector2 spaceBetween = targetTransform.position - transform.position;
		if (isPlayerClose(spaceBetween)){
			TurnToPlayer(spaceBetween);
		} else if (isLookingAtPlayer) {
			TurnBackToDefault();
		}
	}

	void TurnToPlayer(Vector2 spaceBetween) {
		Quaternion rotation = Quaternion.LookRotation(spaceBetween, transform.TransformDirection(Vector3.up));
		transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
		isLookingAtPlayer = true;
	}

	void TurnBackToDefault() {
		transform.rotation = defaultAngle;
		isLookingAtPlayer = true;
	}

	bool isPlayerClose(Vector2 spaceBetween) {
		return Mathf.Abs(spaceBetween.x) <= lookAtPlayerDistance.x && Mathf.Abs(spaceBetween.y) <= lookAtPlayerDistance.y;
	}
}
