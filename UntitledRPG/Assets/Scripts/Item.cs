using UnityEngine;
using System.Collections;
[System.Serializable]

public class Item : MonoBehaviour {

	public ItemScript[] commonArmor = new ItemScript[8];
	public ItemScript[] uncommonArmor = new ItemScript[29];
	public ItemScript[] rareArmor = new ItemScript[18];
	public ItemScript[] relicArmor = new ItemScript[9];

	public ItemScript[] commonWeapons = new ItemScript[15];
	public ItemScript[] uncommonWeapons = new ItemScript[15];
	public ItemScript[] rareWeapons = new ItemScript[15];
	public ItemScript[] relicWeapons = new ItemScript[12];

	//public bool listCreated;

	// -----------------------------------------------------------------------
	// Use this for initialization
	void Start () 
	{
		CreateList();
	}

	void CreateList()
	{
		// ----------------------
		// Common Armor
		// ----------------------

		//tatteredShirt 
		commonArmor[0] = ItemScript.CreateInstance("Tattered Shirt", "A badly tattered shirt", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.chest );
		//AddToList( tatteredShirt, commonArmor, 0 );
		//tatteredPants 
		commonArmor[1] = ItemScript.CreateInstance("Tattered Pants","A badly tattered pair of pants", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.legs );
		//AddToList( tatteredPants, commonArmor, 1 );

		//cleanShirt 
		commonArmor[2] = ItemScript.CreateInstance("Clean Shirt", "A nicley cleaned shirt", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.chest );
		//AddToList( cleanShirt, commonArmor, 2 );
		//cleanPants 
		commonArmor[3] = ItemScript.CreateInstance("Clean Pants", "A nice pair of pants", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.legs );
		//AddToList( cleanPants, commonArmor, 3 );
		//cleanHat 
		commonArmor[4] = ItemScript.CreateInstance("Clean Cap", "A clean cap", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.helm );
		//AddToList( cleanHat, commonArmor, 4 );

		//leatherTunic 
		commonArmor[5] = ItemScript.CreateInstance("Leather Tunic", "A simple leather tunic", 0, 0, 0, 0, 3, ItemScript.Rarity.common, ItemScript.Type.chest );
		//AddToList( leatherTunic, commonArmor, 5 );
		//leatherGreaves 
		commonArmor[6] = ItemScript.CreateInstance("Leather Greaves", "Thick leather greaves", 0, 0, 0, 0, 3, ItemScript.Rarity.common, ItemScript.Type.legs );
		//AddToList( leatherGreaves, commonArmor, 6 );
		//leatherCap 
		commonArmor[7] = ItemScript.CreateInstance("Leather Cap", "A fancy leather cap", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.helm );
		//AddToList( leatherCap, commonArmor, 7 );

		// ----------------------
		// Uncommon Armor
		// ----------------------

		//studdedTunic 
		uncommonArmor[0] = ItemScript.CreateInstance("Studded Tunic", "An uncommon studded tunic", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//studdedCoif 
		uncommonArmor[1] = ItemScript.CreateInstance("Studded Coif", "An uncommon studded coif", 0, 0, 0, 0, 3, ItemScript.Rarity.uncommon, ItemScript.Type.legs );

		//chainmail 
		uncommonArmor[2] = ItemScript.CreateInstance("Chainmail", "A protective chainmail chest plate", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//chainLegs 
		uncommonArmor[3] = ItemScript.CreateInstance("Chain Legs", "Protective chain leggings", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//chainHelmet 
		uncommonArmor[4] = ItemScript.CreateInstance("Chain Helmet", "A light yet protective chain helm", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//platedChest 
		uncommonArmor[5] = ItemScript.CreateInstance("Plated Chest", "A plated piece of chest armor", 0, 0, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//platedBoots 
		uncommonArmor[6] = ItemScript.CreateInstance("Plated Boots", "Plated armor leggings", 0, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//fullHelmet 
		uncommonArmor[7] = ItemScript.CreateInstance("Full Helmet", "A fully proctective helm", 0, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//gryphonHideChest 
		uncommonArmor[8] = ItemScript.CreateInstance("Gryphon Hide Chest", "", 0, 0, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//gryphonHideGreaves 
		uncommonArmor[9] = ItemScript.CreateInstance("Gryphon Hide Greaves", "", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//gryphonHideHelmet 
		uncommonArmor[10] = ItemScript.CreateInstance("Gryphon Hide Helmet", "", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//hessianRobes 
		uncommonArmor[11] = ItemScript.CreateInstance("Hessian Robes", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//hessianBoots 
		uncommonArmor[12] = ItemScript.CreateInstance("Hessian Boots", "", 0, 0, 2, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//hessianCloak 
		uncommonArmor[13] = ItemScript.CreateInstance("Hessian Cloak", "", 0, 0, 2, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//huntsmanChest 
		uncommonArmor[14] = ItemScript.CreateInstance("Huntsman Chest", "", 2, 0, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//huntsmanGreaves 
		uncommonArmor[15] = ItemScript.CreateInstance("Huntsman Greaves", "", 2, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//huntsmanHat 
		uncommonArmor[16] = ItemScript.CreateInstance("Huntsman Hat", "", 2, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//bladedMail 
		uncommonArmor[17] = ItemScript.CreateInstance("Bladed Mail", "", 0, 2, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//bladedBoots 
		uncommonArmor[18] = ItemScript.CreateInstance("Bladed Boots", "", 0, 2, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//bladedSkull 
		uncommonArmor[19] = ItemScript.CreateInstance("Bladed Skull", "", 0, 2, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//ancientRobes 
		uncommonArmor[20] = ItemScript.CreateInstance("Ancient Robes", "", 0, 0, 2, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//ancientSandals 
		uncommonArmor[21] = ItemScript.CreateInstance("Ancient Sandals", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//ancientCloak 
		uncommonArmor[22] = ItemScript.CreateInstance("Ancient Cloak", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//ravenheartMantle 
		uncommonArmor[23] = ItemScript.CreateInstance("Ravenheart Mantle", "", 2, 0, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//ravenheartGreaves 
		uncommonArmor[24] = ItemScript.CreateInstance("Ravenheart Greaves", "", 2, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//ravenheartHood 
		uncommonArmor[25] = ItemScript.CreateInstance("Ravenheart Hood", "", 2, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		//heavyBreastplate 
		uncommonArmor[26] = ItemScript.CreateInstance("Heavy Breastplate", "", 0, 2, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		//heavyJambeau 
		uncommonArmor[27] = ItemScript.CreateInstance("Heavy Jambeau", "", 0, 2, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		//heavyHelmet 
		uncommonArmor[28] = ItemScript.CreateInstance("Heavy Helmet", "", 0, 2, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		// ----------------------
		// Rare Armor
		// ----------------------

		//glowingWrap 
		rareArmor[0] = ItemScript.CreateInstance("Glowing Wrap", "", 0, 0, 3, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//glowingBoots 
		rareArmor[1] = ItemScript.CreateInstance("Glowing Boots", "", 0, 0, 3, 0, 6, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//glowingHood 
		rareArmor[2] = ItemScript.CreateInstance("Glowing Hood", "", 0, 0, 3, 0, 6, ItemScript.Rarity.rare, ItemScript.Type.helm );

		//haughtyVest 
		rareArmor[3] = ItemScript.CreateInstance("Haughty Vest", "", 3, 0, 0, 0, 10, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//haughtyBoots 
		rareArmor[4] = ItemScript.CreateInstance("Haughty Boots", "", 3, 0, 0, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//haughtyHood 
		rareArmor[5] = ItemScript.CreateInstance("Haughty Hood", "", 3, 0, 0, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.helm );

		//knightsMantle 
		rareArmor[6] = ItemScript.CreateInstance("Knight's Mantle", "", 0, 3, 0, 0, 13, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//knightsGreaves 
		rareArmor[7] = ItemScript.CreateInstance("Knight's Greaves", "", 0, 3, 0, 0, 11, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//knightsHelm 
		rareArmor[8] = ItemScript.CreateInstance("Knight's Helm", "", 0, 3, 0, 0, 11, ItemScript.Rarity.rare, ItemScript.Type.helm );

		//necroticRobe 
		rareArmor[9] = ItemScript.CreateInstance("Necrotic Robe", "", 0, 0, 4, 0, 10, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//necroticBoots 
		rareArmor[10] = ItemScript.CreateInstance("Necrotic Boots", "", 0, 0, 4, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//necroticHood 
		rareArmor[11] = ItemScript.CreateInstance("Necrotic Hood", "", 0, 0, 4, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.helm );

		//recluseVest 
		rareArmor[12] = ItemScript.CreateInstance("Recluse's Vest", "", 4, 0, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//recluseGreaves 
		rareArmor[13] = ItemScript.CreateInstance("Recluse's Greaves", "", 4, 0, 0, 0, 9, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//recluseMask 
		rareArmor[14] = ItemScript.CreateInstance("Recluse's Mask", "", 4, 0, 0, 0, 9, ItemScript.Rarity.rare, ItemScript.Type.helm );

		//greyIcePlate 
		rareArmor[15] = ItemScript.CreateInstance("Grey Ice Plate", "", 0, 4, 0, 0, 15, ItemScript.Rarity.rare, ItemScript.Type.chest );
		//greyIceGreaves 
		rareArmor[16] = ItemScript.CreateInstance("Grey Ice Greaves", "", 0, 4, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.legs );
		//greyIceHelm 
		rareArmor[17] = ItemScript.CreateInstance("Grey Ice Helm", "", 0, 4, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.helm );

		// ----------------------
		// Relic Armor
		// ----------------------

		//robesOfTheUndying 
		relicArmor[0] = ItemScript.CreateInstance("Robes of the Undying", "", 1, 3, 6, 0, 14, ItemScript.Rarity.relic, ItemScript.Type.chest );
		//undyingBoots 
		relicArmor[1] = ItemScript.CreateInstance("Undying Boots", "", 1, 3, 6, 0, 12, ItemScript.Rarity.relic, ItemScript.Type.legs );
		//periaptOfUndeath 
		relicArmor[2] = ItemScript.CreateInstance("Periapt of Undeath", "", 1, 3, 6, 0, 12, ItemScript.Rarity.relic, ItemScript.Type.helm );

		//forgottenMartyrVest 
		relicArmor[3] = ItemScript.CreateInstance("Forgotten Martyr's Vest", "", 6, 1, 3, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.chest );
		//fallenMartyrGreaves 
		relicArmor[4] = ItemScript.CreateInstance("Fallen Martyr's Greaves", "", 6, 1, 3, 0, 13, ItemScript.Rarity.relic, ItemScript.Type.legs );
		//shadowedMartyrCloak 
		relicArmor[5] = ItemScript.CreateInstance("Shadowed Martyr's Cloak", "", 6, 1, 3, 0, 13, ItemScript.Rarity.relic, ItemScript.Type.helm );

		//noSalvation 
		relicArmor[6] = ItemScript.CreateInstance("No Salvation", "", 3, 6, 1, 0, 20, ItemScript.Rarity.relic, ItemScript.Type.chest );
		//noMercy 
		relicArmor[7] = ItemScript.CreateInstance("No Mercy", "", 3, 6, 1, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.legs );
		//noSolace 
		relicArmor[8] = ItemScript.CreateInstance("No Solace", "", 3, 6, 1, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.helm );

		// ----------------------
		// Common Weapons
		// ----------------------

		//rustedSword 
		commonWeapons[0] = ItemScript.CreateInstance("Rusted Sword", "A dull and rusty sword", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//twistedBranch 
		commonWeapons[1] = ItemScript.CreateInstance("Twisted Branch", "", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//crudeBow 
		commonWeapons[2] = ItemScript.CreateInstance("Crude Bow", "", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//bronzeSword 
		commonWeapons[3] = ItemScript.CreateInstance("Bronze Sword", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//enchantedStick 
		commonWeapons[4] = ItemScript.CreateInstance("Enchanted Stick", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//averageBow 
		commonWeapons[5] = ItemScript.CreateInstance("Average Bow", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//ironSword 
		commonWeapons[6] = ItemScript.CreateInstance("Iron Sword", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//magicWand 
		commonWeapons[7] = ItemScript.CreateInstance("Magic Wand", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//compoundBow 
		commonWeapons[8] = ItemScript.CreateInstance("Compound Bow", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//steelSword 
		commonWeapons[9] = ItemScript.CreateInstance("Steel Sword", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//enchantedRod 
		commonWeapons[10] = ItemScript.CreateInstance("Enchanted Rod", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//mightyBow 
		commonWeapons[11] = ItemScript.CreateInstance("Mighty Bow", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//scimitar 
		commonWeapons[12] = ItemScript.CreateInstance("Scimitar", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//magicRod 
		commonWeapons[13] = ItemScript.CreateInstance("Magic Rod", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		//longBow 
		commonWeapons[14] = ItemScript.CreateInstance("Long Bow", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );

		// ----------------------
		// Uncommon Weapons
		// ----------------------

		//greatSword 
		uncommonWeapons[0] = ItemScript.CreateInstance("Great Sword", "", 0, 0, 0, 6, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//enchantedStaff 
		uncommonWeapons[1] = ItemScript.CreateInstance("Enchanted Staff", "", 0, 0, 0, 6, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//elvenBow 
		uncommonWeapons[2] = ItemScript.CreateInstance("Elven Bow", "", 0, 0, 0, 6, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//claymore 
		uncommonWeapons[3] = ItemScript.CreateInstance("Claymore", "", 0, 0, 0, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//magicStaff 
		uncommonWeapons[4] = ItemScript.CreateInstance("Magic Staff", "", 0, 0, 0, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//quickBow 
		uncommonWeapons[5] = ItemScript.CreateInstance("Quick Bow", "", 0, 0, 0, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//Scythe 
		uncommonWeapons[6] = ItemScript.CreateInstance("Scythe", "", 0, 1, 0, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//runeStaff 
		uncommonWeapons[7] = ItemScript.CreateInstance("Rune Staff", "", 0, 0, 1, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//silverBow 
		uncommonWeapons[8] = ItemScript.CreateInstance("Silver Bow", "", 0, 1, 0, 7, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//katana 
		uncommonWeapons[9] = ItemScript.CreateInstance("Katana", "", 0, 2, 0, 9, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//archStaff 
		uncommonWeapons[10] = ItemScript.CreateInstance("Arch Staff", "", 0, 0, 2, 9, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//blackBow 
		uncommonWeapons[11] = ItemScript.CreateInstance("Black Bow", "", 0, 2, 0, 9, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//largeAsi 
		uncommonWeapons[12] = ItemScript.CreateInstance("Large Asi", "", 0, 2, 0, 12, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//enchantedSceptre 
		uncommonWeapons[13] = ItemScript.CreateInstance("Enchanted Sceptre", "", 0, 0, 2, 12, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );
		//recurveBow 
		uncommonWeapons[14] = ItemScript.CreateInstance("Recurve Bow", "", 0, 2, 0, 12, 0, ItemScript.Rarity.uncommon, ItemScript.Type.weapon );

		// ----------------------
		// Rare Weapons
		// ----------------------

		//khopesh 
		rareWeapons[0] = ItemScript.CreateInstance("Khopesh", "", 0, 3, 0, 14, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//magicSceptre 
		rareWeapons[1] = ItemScript.CreateInstance("Magic Sceptre", "", 0, 0, 3, 14, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//reinforcedBow 
		rareWeapons[2] = ItemScript.CreateInstance("Reinforced Bow", "", 0, 3, 0, 14, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//zweihander 
		rareWeapons[3] = ItemScript.CreateInstance("Zweihander", "", 0, 4, 0, 18, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//runicSceptre 
		rareWeapons[4] = ItemScript.CreateInstance("Runic Sceptre", "", 0, 0, 4, 18, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//reflexBow 
		rareWeapons[5] = ItemScript.CreateInstance("Reflex Bow", "", 0, 4, 0, 18, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//serratedSabre 
		rareWeapons[6] = ItemScript.CreateInstance("Serrated Sabre", "", 0, 5, 0, 21, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//enchantedQuarterstaff 
		rareWeapons[7] = ItemScript.CreateInstance("Enchanted Quarterstaff", "", 0, 0, 5, 21, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//daggerBow 
		rareWeapons[8] = ItemScript.CreateInstance("Dagger Bow", "", 0, 5, 0, 21, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//kaskara 
		rareWeapons[9] = ItemScript.CreateInstance("Kaskara", "", 0, 6, 0, 25, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//magicQuarterstaff 
		rareWeapons[10] = ItemScript.CreateInstance("Magic Quarterstaff", "", 0, 0, 6, 25, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//selfBow 
		rareWeapons[11] = ItemScript.CreateInstance("Self Bow", "", 0, 6, 0, 25, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//shamsir 
		rareWeapons[12] = ItemScript.CreateInstance("Shamsir", "", 0, 6, 1, 27, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//runicQuarterstaff 
		rareWeapons[13] = ItemScript.CreateInstance("Runic Quarterstaff", "", 0, 1, 6, 27, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );
		//swordBow 
		rareWeapons[14] = ItemScript.CreateInstance("Sword Bow", "", 0, 6, 1, 27, 0, ItemScript.Rarity.rare, ItemScript.Type.weapon );

		// ----------------------
		// Relic Weapons
		// ----------------------

		//soulReaver 
		relicWeapons[0] = ItemScript.CreateInstance("Soul Reaver", "", 0, 6, 3, 32, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//wandOfThousandTruths 
		relicWeapons[1] = ItemScript.CreateInstance("Wand of 1,000 Truths", "", 0, 3, 6, 33, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//messenger 
		relicWeapons[2] = ItemScript.CreateInstance("Messenger", "", 1, 5, 2, 32, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//cosmicHorror 
		relicWeapons[3] = ItemScript.CreateInstance("Cosmic Horror", "", 0, 7, 3, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//necropolis 
		relicWeapons[4] = ItemScript.CreateInstance("Necropolis", "", 0, 3, 7, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//theRaven 
		relicWeapons[5] = ItemScript.CreateInstance("The Raven", "", 0, 7, 3, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//worldEater 
		relicWeapons[6] = ItemScript.CreateInstance("World Eater", "", 0, 8, 4, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//livingDead 
		relicWeapons[7] = ItemScript.CreateInstance("Living Dead", "", 0, 4, 8, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//requiem 
		relicWeapons[8] = ItemScript.CreateInstance("Requiem", "", 0, 8, 4, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//law 
		relicWeapons[9] = ItemScript.CreateInstance("Law", "", 1, 9, 6, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//judgement 
		relicWeapons[10] = ItemScript.CreateInstance("Judgement", "", 1, 6, 9, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		//truth 
		relicWeapons[11] = ItemScript.CreateInstance("Truth", "", 1, 9, 6, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );

		//listCreated = true;
	}

	void AddToList( ItemScript itemToAdd, ItemScript[] listToAddTo, int placeInList )
	{
		listToAddTo[placeInList] = itemToAdd;
	}

	// Update is called once per frame
	void Update () 
	{
		//print ( tatteredShirt.description );
	}
}
