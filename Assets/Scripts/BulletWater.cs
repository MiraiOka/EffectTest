using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWater : MonoBehaviour {
	private Vector3 hitPoint;
	[SerializeField] WaterEffectController waterEffectController;

	void OnCollisionEnter(Collision other)
	{

		print (other.gameObject.tag);
		if (other.gameObject.tag == "Fire") {
			GameObject fire = other.transform.Find ("fire1_add").gameObject;
			if (fire.transform.localScale.x == 1) {
				Destroy (other.gameObject);
			} else {
				fire.transform.localScale -= new Vector3 (1, 1, 1);
			}

			Destroy (this.gameObject);
		} else {
			Destroy (this.gameObject);
			hitPoint = this.transform.position;
			waterEffectController.createWater (hitPoint);
		}
	}
}
