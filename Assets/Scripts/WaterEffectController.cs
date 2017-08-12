using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEffectController : MonoBehaviour {

	public void createWater(Vector3 hitPoint)
	{
		Instantiate (this.gameObject, hitPoint, Quaternion.identity);
	}
}
