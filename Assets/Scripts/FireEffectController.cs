using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffectController : MonoBehaviour {

	public void createFire(Vector3 hitPoint)
	{
		Instantiate (this.gameObject, hitPoint, Quaternion.identity);
	}
}
