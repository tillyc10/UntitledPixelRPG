using UnityEngine;
using System.Collections;

public class EnemiesList : MonoBehaviour
{
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
	public string[] zoneTwelveEnemies = new string[3];
	public string[] zoneThirteenEnemies = new string[3];
	public string[] zoneFourteenEnemies = new string[3];

		// Use this for initialization
		void Start ()
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
	

		void Update ()
		{
		
		}
}

