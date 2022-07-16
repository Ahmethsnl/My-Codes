using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_cntrl : MonoBehaviour {
	void FixedUpdate()
	{
		horizontal = Input.GetAxis ("Horizontal");
		// 0 sa duruyorduk ancak negatifse sola pozitifse sağa 
		transform.position += new Vector3 (horizontal, 0, 0);
	}
}
