using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {
	private Vector3 hitPoint;
	[SerializeField] FireEffectController fireEffectController;

	void OnCollisionEnter(Collision other)
	{

		print (other.gameObject.tag);
		if (other.gameObject.tag == "Fire") {
			other.transform.Find("fire1_add").gameObject.transform.localScale += new Vector3 (1, 1, 1);
			Destroy (this.gameObject);
		} else {
			Destroy (this.gameObject);
			hitPoint = this.transform.position;
			fireEffectController.createFire (hitPoint);
		}
	}
}
