using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseEnemy : MonoBehaviour 
{
	public string enemyName;
	public string enemyDescription;
	public int enemyLevel;
	public int enemyHealth;
	public int enemyDamage;
	public int enemyDefense;
	public int enemyGold;
	public string enemyType;

	public string EnemyType;  
	{
		GrimRat,
		GrimSlime,
		GrimHornet,
		GrimBat
		//full list will go here
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

