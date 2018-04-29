using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour 
{

	
	void Update () 
	{
		//rotates the transform of the pickup object
		
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}









}
