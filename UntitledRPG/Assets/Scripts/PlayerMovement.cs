using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float walkSpeed;
	private float curHeld;
	private float recentPress;
	private float playerWalking;
	public Transform Hero;
	// Enemy Arrays
	public string[] zoneOneEnemies = new string[4];
	public string[] zoneTwoEnemies = new string[3];
	public string[] zoneThreeEnemies = new string[3];
	public string[] zoneFourEnemies = new string[3];
	public string[] zoneFiveEnemies = new string[3];
	public string[] zoneSixEnemies = new string[3];
	public string[] zoneSevenEnemies = new string[3];
	public string[] zoneEightEnemies = new string[3];
	public string[] zoneNineEnemies = new string[3];
	public string[] zoneTenEnemies = new string[3];
	public string[] zoneElevenEnemies = new string[3];
	public string[] zoneTweleveEnemies = new string[3];
	public string[] zoneThirteenEnemies = new string[3];
	public string[] zoneFourteenEnemies = new string[3];

	void Awake ()
	{
		DontDestroyOnLoad (Hero);
	}
	void Start()
	{
		CreateList();
	
	}

	void CreateList()
	{
				zoneOneEnemies [0] = "Grim Rat";
				zoneOneEnemies [1] = "Grim Slime";
				zoneOneEnemies [2] = "Grim Hornet";
				zoneOneEnemies [3] = "Grim Bat";

				zoneTwoEnemies [0] = "Grim Hare";
				zoneTwoEnemies [1] = "Grim Raven";
				zoneTwoEnemies [2] = "Grim Spider";

				zoneThreeEnemies [0] = "Boulderlings";
				zoneThreeEnemies [1] = "Grim Serpent";
				zoneThreeEnemies [2] = "Rock Goblin";
		
				zoneFourEnemies [0] = "Grim Boar";
				zoneFourEnemies [1] = "Grim Treeling";
				zoneFourEnemies [2] = "Grim Wolf";

				zoneFiveEnemies [0] = "Grim Scorpion";
				zoneFiveEnemies [1] = "Dustling";
				zoneFiveEnemies [2] = "Giant Tarantula";

				zoneSixEnemies [0] = "Giant Scorpion";
				zoneSixEnemies [1] = "Grim Duster";
				zoneSixEnemies [2] = "Giant Horned Lizard";

				zoneSevenEnemies [0] = "Giant Grim Slime";
				zoneSevenEnemies [1] = "Grim Bear";
				zoneSevenEnemies [2] = "Troll";

				zoneEightEnemies [0] = "Rock Goblin";
				zoneEightEnemies [1] = "Grim Ram";
				zoneEightEnemies [2] = "Grim Eagle";

				zoneNineEnemies [0] = "Giant Grim Hornet";
				zoneNineEnemies [1] = "Goblins";
				zoneNineEnemies [2] = "Grim Lake Bass";

				zoneTenEnemies [0] = "Giant Grim Boar";
				zoneTenEnemies [1] = "Giant Grim Boar";
				zoneTenEnemies [2] = "Treeling";

				zoneElevenEnemies [0] = "Boulderlings";
				zoneElevenEnemies [1] = "Giant Grim Bat";
				zoneElevenEnemies [2] = "Chimera";

				zoneTwelveEnemies [0] = "Giant Grim Rat";
				zoneTwelveEnemies [1] = "Giant Grim Lake Bass";
				zoneTwelveEnemies [2] = "Giant";

				zoneThirteenEnemies [0] = "Giant Grim Serpent";
				zoneThirteenEnemies [1] = "Merfolk";
				zoneThirteenEnemies [2] = "Shadow Cat";

				zoneFourteenEnemies [0] = "Frenzied Troll";
				zoneFourteenEnemies [1] = "Frenzied Goblin";
				zoneFourteenEnemies [2] = "Frenzied Giant";

	}

	//void battleStart
	//{
		//Randomly kick into battle screen
	//}

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

		if (rigidbody2D.velocity > 0) 
		{
			timeWalking += Time.deltaTime;
		}

	}


	void FixedUpdate()
	{
		/*MovePlayer ();

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
		rigidbody2D.rotation = 0;*/
	}

}
