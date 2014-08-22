using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float walkSpeed;

	private float curHeld;
	private float recentPress;

	void Start()
	{

	}

	// Returns value of true to move horizontal and false to move vertical
	private bool MoveWhichWay (float moveHorizontal, float moveVertical)
	{
		if ( moveVertical == 0 && moveHorizontal == 0 )
		{
			curHeld = 0;
			recentPress = 0;
			return false;
		}
		else if ( moveVertical == 0 && moveHorizontal != 0 )
		{
			curHeld = 1;
			recentPress = 1;
			return true;
		}
		else if ( moveVertical != 0 && moveHorizontal == 0 )
		{
			curHeld = 2;
			recentPress = 2;
			return false;
		}
		else if ( moveVertical != 0 && moveHorizontal != 0 )
		{
			if ( curHeld == 1 && recentPress == 1 )
			{
				return false;
			}
			else if ( curHeld == 1 && recentPress == 2 )
			{
				curHeld = 2;
				return true;
			}
			else if ( curHeld == 2 && recentPress == 1 )
			{
				curHeld = 1;
				return false;
			}
			else if ( curHeld == 2 && recentPress == 2 )
			{
				return true;
			}

			return false;
		}

		return false;
	}

	void MovePlayer ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if ( MoveWhichWay( moveHorizontal, moveVertical ) )
		{
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
			rigidbody2D.velocity = movement * walkSpeed;
		}
		else
		{
			Vector3 movement = new Vector3 (0.0f, moveVertical, 0.0f);
			rigidbody2D.velocity = movement * walkSpeed;
		}

		rigidbody2D.rotation = 0;
	}

	void FixedUpdate()
	{
		MovePlayer ();

		/*float moveHorizontal = Input.GetAxis ("Horizontal");
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
		rigidbody2D.rotation = 0;*/
	}

}
