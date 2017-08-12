using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	[SerializeField] GameObject bulletFire;
	[SerializeField] GameObject bulletWater;
	[SerializeField] Camera playerCamera;
	[SerializeField] float speed = 20;

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) {
			GameObject bullet2 = (GameObject)Instantiate (bulletFire, playerCamera.transform.position, Quaternion.identity);
			Ray rayOrigin = playerCamera.ScreenPointToRay (Input.mousePosition);
			Vector3 direction = rayOrigin.direction;
			bullet2.GetComponent<Rigidbody> ().velocity = direction * speed;
		} else if (Input.GetMouseButtonDown (1)) {
			GameObject bullet2 = (GameObject)Instantiate (bulletWater, playerCamera.transform.position, Quaternion.identity);
			Ray rayOrigin = playerCamera.ScreenPointToRay (Input.mousePosition);
			Vector3 direction = rayOrigin.direction;
			bullet2.GetComponent<Rigidbody> ().velocity = direction * speed;
		}


	}
}
