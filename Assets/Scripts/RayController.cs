using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	[SerializeField] GameObject bullet;
	[SerializeField] Camera playerCamera;
	[SerializeField] float speed = 20;

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) {
			GameObject bullet2 = (GameObject) Instantiate (bullet, playerCamera.transform.position, Quaternion.identity);
			Ray rayOrigin = playerCamera.ScreenPointToRay (Input.mousePosition);
			Vector3 direction = rayOrigin.direction;

			bullet2.GetComponent<Rigidbody> ().velocity = direction * speed;
		}


	}
}
