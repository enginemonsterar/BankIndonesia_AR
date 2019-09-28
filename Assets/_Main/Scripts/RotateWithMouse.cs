using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotateWithMouse : MonoBehaviour {

	float rotSpeed = 0.1f;
	[SerializeField] private bool Horizontal;
	[SerializeField] private bool Vertical;

	void OnMouseDrag(){
		float rotX = 0;
		float rotY = 0;
		if(Horizontal)
			rotX = Input.GetAxis("Mouse X") * rotSpeed ;

		if(Vertical)
			rotY = Input.GetAxis("Mouse Y") * rotSpeed ;

		transform.RotateAround(Vector3.up, -rotX);
		transform.RotateAround(Vector3.right, rotY);
	}
}
