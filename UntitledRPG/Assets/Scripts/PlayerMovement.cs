using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float walkSpeed;

	void Start()
	{

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		if (moveHorizontal > 0 || moveHorizontal < 0) 
		{
			moveVertical = 0.0f;
		} 
		if (moveVertical > 0 || moveVertical < 0) 
		{
			moveHorizontal = 0.0f;
		}
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

			

		rigidbody2D.velocity = movement * walkSpeed;
		rigidbody2D.rotation = 0;
	}

}
