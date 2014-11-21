using UnityEngine;
using System.Collections;

public class FacePlayer : MonoBehaviour {

	public GameObject target;
	public Vector2 lookAtPlayerDistance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 spaceBetween = target.transform.position - transform.position;
		if(Mathf.Abs(spaceBetween.x) <= lookAtPlayerDistance.x && Mathf.Abs(spaceBetween.y) <= lookAtPlayerDistance.y){
			Quaternion rotation = Quaternion.LookRotation(spaceBetween, transform.TransformDirection(Vector3.up));
			transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
		}
	}
}
