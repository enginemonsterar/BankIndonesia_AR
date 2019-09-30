using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotateWithMouse : MonoBehaviour {

	float rotSpeed = 3f;

	void OnMouseDrag(){
		float rotX = Input.GetAxis("Mouse X") * rotSpeed ;
		float rotY = Input.GetAxis("Mouse Y") * rotSpeed ;

		transform.Rotate(Vector3.forward, rotX);
		// transform.Rotate(Vector3.right, rotY);
	}
}
