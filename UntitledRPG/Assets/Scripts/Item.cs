using UnityEngine;
using System.Collections;
[System.Serializable]

public class Item : MonoBehaviour {

	public ItemScript[] itemList = new ItemScript[10];

	// Armor
	public ItemScript tatteredShirt;
	public ItemScript tatteredPants;

	// Weapons
	public ItemScript rustedSword;

	// How much of this item do we have?
	private int count;

	// Use this for initialization
	void Start () 
	{
		CreateList();
	}

	void CreateList()
	{
		// Armor
		tatteredShirt = ItemScript.CreateInstance("Tattered Shirt", "A badly tattered shirt", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.chest );
		tatteredPants = ItemScript.CreateInstance("Tattered Pants","A badly tattered pair of pants", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.legs );

		// Weapons
		rustedSword = ItemScript.CreateInstance("Rusted Sword", "A dull and rusty sword", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
