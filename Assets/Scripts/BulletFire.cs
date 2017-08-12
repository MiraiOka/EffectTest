using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {
	private Vector3 hitPoint;
	[SerializeField] FireEffectController fireEffectController;

	void OnCollisionEnter()
	{
		Destroy (this.gameObject);
		hitPoint = this.transform.position;
		fireEffectController.createFire (hitPoint);
	}
}
