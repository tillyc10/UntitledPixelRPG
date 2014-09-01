using UnityEngine;
using System.Collections;
[System.Serializable]

public class Item : MonoBehaviour {

	public ItemScript[] itemList = new ItemScript[10];

	// Armor
	public ItemScript tatteredShirt;
	public ItemScript tatteredPants;
	public ItemScript cleanShirt;
	public ItemScript cleanPants;
	public ItemScript cleanHat;
	public ItemScript leatherTunic;
	public ItemScript leatherGreaves;
	public ItemScript leatherCap;
	public ItemScript studdedTunic;
	public ItemScript studdedCoif;
	public ItemScript chainmail;
	public ItemScript chainLegs;
	public ItemScript chainHelmet;
	public ItemScript platedChest;
	public ItemScript platedBoots;
	public ItemScript fullHelmet;
	public ItemScript gryphonHideChest;
	public ItemScript gryphonHideGreaves;
	public ItemScript gryphonHideHelmet;
	public ItemScript hessianRobes;
	public ItemScript hessianBoots;
	public ItemScript hessianCloak;
	public ItemScript huntsmanChest;
	public ItemScript huntsmanGreaves;
	public ItemScript huntsmanHat;
	public ItemScript bladedMail;
	public ItemScript bladedBoots;
	public ItemScript bladedSkull;
	public ItemScript ancientRobes;
	public ItemScript ancientSandals;
	public ItemScript ancientCloak;
	public ItemScript ravenheartMantle;
	public ItemScript ravenheartGreaves;
	public ItemScript ravenheartHood;
	public ItemScript heavyBreastplate;
	public ItemScript heavyJambeau;
	public ItemScript heavyHelmet;
	public ItemScript glowingWrap;
	public ItemScript glowingBoots;
	public ItemScript glowingHood;
	public ItemScript haughtyVest;
	public ItemScript haughtyBoots;
	public ItemScript haughtyHood;
	public ItemScript knightsMantle;
	public ItemScript knightsGreaves;
	public ItemScript knightsHelm;
	public ItemScript necroticRobe;
	public ItemScript necroticBoots;
	public ItemScript necroticHood;
	public ItemScript recluseVest;
	public ItemScript recluseGreaves;
	public ItemScript recluseMask;
	public ItemScript greyIcePlate;
	public ItemScript greyIceGreaves;
	public ItemScript greyIceHelm;
	public ItemScript robesOfTheUndying;
	public ItemScript undyingBoots;
	public ItemScript periaptOfUndeath;
	public ItemScript forgottenMartyrVest;
	public ItemScript fallenMartyrGreaves;
	public ItemScript shadowedMartyrCloak;
	public ItemScript noSalvation;
	public ItemScript noMercy;
	public ItemScript noSolace;
	
	// Weapons
	public ItemScript rustedSword;
	public ItemScript twistedBranch;
	public ItemScript crudeBow;
	public ItemScript bronzeSword;
	public ItemScript enchantedStick;
	public ItemScript averageBow;
	public ItemScript ironSword;
	public ItemScript magicWand;
	public ItemScript compoundBow;
	public ItemScript steelSword;
	public ItemScript enchantedRod;
	public ItemScript mightyBow;
	public ItemScript scimitar;
	public ItemScript magicRod;
	public ItemScript longBow;
	public ItemScript greatSword;
	public ItemScript enchantedStaff;
	public ItemScript elvenBow;
	public ItemScript claymore;
	public ItemScript magicStaff;
	public ItemScript quickBow;
	public ItemScript Scythe;
	public ItemScript runeStaff;
	public ItemScript silverBow;
	public ItemScript katana;
	public ItemScript archStaff;
	public ItemScript blackBow;
	public ItemScript largeAsi;
	public ItemScript enchantedSceptre;
	public ItemScript recurveBow;
	public ItemScript khopesh;
	public ItemScript magicSceptre;
	public ItemScript reinforcedBow;
	public ItemScript zweihander;
	public ItemScript runicSceptre;
	public ItemScript reflexBow;
	public ItemScript serratedSabre;
	public ItemScript enchantedQuarterstaff;
	public ItemScript daggerBow;
	public ItemScript kaskara;
	public ItemScript magicQuarterstaff;
	public ItemScript selfBow;
	public ItemScript shamsir;
	public ItemScript runicQuarterstaff;
	public ItemScript swordBow;

	public ItemScript soulReaver;
	public ItemScript wandOfThousandTruths;
	public ItemScript messenger;
	public ItemScript cosmicHorror;
	public ItemScript necropolis;
	public ItemScript theRaven;
	public ItemScript worldEater;
	public ItemScript livingDead;
	public ItemScript requiem;
	public ItemScript law;
	public ItemScript judgement;
	public ItemScript truth;

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

		cleanShirt = ItemScript.CreateInstance("Clean Shirt", "A nicley cleaned shirt", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.chest );
		cleanPants = ItemScript.CreateInstance("Clean Pants", "A nice pair of pants", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.legs );
		cleanHat = ItemScript.CreateInstance("Clean Cap", "A clean cap", 0, 0, 0, 0, 1, ItemScript.Rarity.common, ItemScript.Type.helm );

		leatherTunic = ItemScript.CreateInstance("Leather Tunic", "A simple leather tunic", 0, 0, 0, 0, 3, ItemScript.Rarity.common, ItemScript.Type.chest );
		leatherGreaves = ItemScript.CreateInstance("Leather Greaves", "Thick leather greaves", 0, 0, 0, 0, 3, ItemScript.Rarity.common, ItemScript.Type.legs );
		leatherCap = ItemScript.CreateInstance("Leather Cap", "A fancy leather cap", 0, 0, 0, 0, 2, ItemScript.Rarity.common, ItemScript.Type.helm );

		studdedTunic = ItemScript.CreateInstance("Studded Tunic", "An uncommon studded tunic", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		studdedCoif = ItemScript.CreateInstance("Studded Coif", "An uncommon studded coif", 0, 0, 0, 0, 3, ItemScript.Rarity.uncommon, ItemScript.Type.legs );

		chainmail = ItemScript.CreateInstance("Chainmail", "A protective chainmail chest plate", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		chainLegs = ItemScript.CreateInstance("Chain Legs", "Protective chain leggings", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		chainHelmet = ItemScript.CreateInstance("Chain Helmet", "A light yet protective chain helm", 0, 0, 0, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		platedChest = ItemScript.CreateInstance("Plated Chest", "A plated piece of chest armor", 0, 0, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		platedBoots = ItemScript.CreateInstance("Plated Boots", "Plated armor leggings", 0, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		fullHelmet = ItemScript.CreateInstance("Full Helmet", "A fully proctective helm", 0, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		gryphonHideChest = ItemScript.CreateInstance("Gryphon Hide Chest", "", 0, 0, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		gryphonHideGreaves = ItemScript.CreateInstance("Gryphon Hide Greaves", "", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		gryphonHideHelmet = ItemScript.CreateInstance("Gryphon Hide Helmet", "", 0, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		hessianRobes = ItemScript.CreateInstance("Hessian Robes", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		hessianBoots = ItemScript.CreateInstance("Hessian Boots", "", 0, 0, 2, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		hessianCloak = ItemScript.CreateInstance("Hessian Cloak", "", 0, 0, 2, 0, 4, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		huntsmanChest = ItemScript.CreateInstance("Huntsman Chest", "", 2, 0, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		huntsmanGreaves = ItemScript.CreateInstance("Huntsman Greaves", "", 2, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		huntsmanHat = ItemScript.CreateInstance("Huntsman Hat", "", 2, 0, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		bladedMail = ItemScript.CreateInstance("Bladed Mail", "", 0, 2, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		bladedBoots = ItemScript.CreateInstance("Bladed Boots", "", 0, 2, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		bladedSkull = ItemScript.CreateInstance("Bladed Skull", "", 0, 2, 0, 0, 5, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		ancientRobes = ItemScript.CreateInstance("Ancient Robes", "", 0, 0, 2, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		ancientSandals = ItemScript.CreateInstance("Ancient Sandals", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		ancientCloak = ItemScript.CreateInstance("Ancient Cloak", "", 0, 0, 2, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		ravenheartMantle = ItemScript.CreateInstance("Ravenheart Mantle", "", 2, 0, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		ravenheartGreaves = ItemScript.CreateInstance("Ravenheart Greaves", "", 2, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		ravenheartHood = ItemScript.CreateInstance("Ravenheart Hood", "", 2, 0, 0, 0, 6, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		heavyBreastplate = ItemScript.CreateInstance("Heavy Breastplate", "", 0, 2, 0, 0, 8, ItemScript.Rarity.uncommon, ItemScript.Type.chest );
		heavyJambeau = ItemScript.CreateInstance("Heavy Jambeau", "", 0, 2, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.legs );
		heavyHelmet = ItemScript.CreateInstance("Heavy Helmet", "", 0, 2, 0, 0, 7, ItemScript.Rarity.uncommon, ItemScript.Type.helm );

		glowingWrap = ItemScript.CreateInstance("Glowing Wrap", "", 0, 0, 3, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.chest );
		glowingBoots = ItemScript.CreateInstance("Glowing Boots", "", 0, 0, 3, 0, 6, ItemScript.Rarity.rare, ItemScript.Type.legs );
		glowingHood = ItemScript.CreateInstance("Glowing Hood", "", 0, 0, 3, 0, 6, ItemScript.Rarity.rare, ItemScript.Type.helm );

		haughtyVest = ItemScript.CreateInstance("Haughty Vest", "", 3, 0, 0, 0, 10, ItemScript.Rarity.rare, ItemScript.Type.chest );
		haughtyBoots = ItemScript.CreateInstance("Haughty Boots", "", 3, 0, 0, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.legs );
		haughtyHood = ItemScript.CreateInstance("Haughty Hood", "", 3, 0, 0, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.helm );

		knightsMantle = ItemScript.CreateInstance("Knight's Mantle", "", 0, 3, 0, 0, 13, ItemScript.Rarity.rare, ItemScript.Type.chest );
		knightsGreaves = ItemScript.CreateInstance("Knight's Greaves", "", 0, 3, 0, 0, 11, ItemScript.Rarity.rare, ItemScript.Type.legs );
		knightsHelm = ItemScript.CreateInstance("Knight's Helm", "", 0, 3, 0, 0, 11, ItemScript.Rarity.rare, ItemScript.Type.helm );

		necroticRobe = ItemScript.CreateInstance("Necrotic Robe", "", 0, 0, 4, 0, 10, ItemScript.Rarity.rare, ItemScript.Type.chest );
		necroticBoots = ItemScript.CreateInstance("Necrotic Boots", "", 0, 0, 4, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.legs );
		necroticHood = ItemScript.CreateInstance("Necrotic Hood", "", 0, 0, 4, 0, 8, ItemScript.Rarity.rare, ItemScript.Type.helm );

		recluseVest = ItemScript.CreateInstance("Recluse's Vest", "", 4, 0, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.chest );
		recluseGreaves = ItemScript.CreateInstance("Recluse's Greaves", "", 4, 0, 0, 0, 9, ItemScript.Rarity.rare, ItemScript.Type.legs );
		recluseMask = ItemScript.CreateInstance("Recluse's Mask", "", 4, 0, 0, 0, 9, ItemScript.Rarity.rare, ItemScript.Type.helm );

		greyIcePlate = ItemScript.CreateInstance("Grey Ice Plate", "", 0, 4, 0, 0, 15, ItemScript.Rarity.rare, ItemScript.Type.chest );
		greyIceGreaves = ItemScript.CreateInstance("Grey Ice Greaves", "", 0, 4, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.legs );
		greyIceHelm = ItemScript.CreateInstance("Grey Ice Helm", "", 0, 4, 0, 0, 12, ItemScript.Rarity.rare, ItemScript.Type.helm );

		robesOfTheUndying = ItemScript.CreateInstance("Robes of the Undying", "", 1, 3, 6, 0, 14, ItemScript.Rarity.relic, ItemScript.Type.chest );
		undyingBoots = ItemScript.CreateInstance("Undying Boots", "", 1, 3, 6, 0, 12, ItemScript.Rarity.relic, ItemScript.Type.legs );
		periaptOfUndeath = ItemScript.CreateInstance("Periapt of Undeath", "", 1, 3, 6, 0, 12, ItemScript.Rarity.relic, ItemScript.Type.helm );

		forgottenMartyrVest = ItemScript.CreateInstance("Forgotten Martyr's Vest", "", 6, 1, 3, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.chest );
		fallenMartyrGreaves = ItemScript.CreateInstance("Fallen Martyr's Greaves", "", 6, 1, 3, 0, 13, ItemScript.Rarity.relic, ItemScript.Type.legs );
		shadowedMartyrCloak = ItemScript.CreateInstance("Shadowed Martyr's Cloak", "", 6, 1, 3, 0, 13, ItemScript.Rarity.relic, ItemScript.Type.helm );

		noSalvation = ItemScript.CreateInstance("No Salvation", "", 3, 6, 1, 0, 20, ItemScript.Rarity.relic, ItemScript.Type.chest );
		noMercy = ItemScript.CreateInstance("No Mercy", "", 3, 6, 1, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.legs );
		noSolace = ItemScript.CreateInstance("No Solace", "", 3, 6, 1, 0, 16, ItemScript.Rarity.relic, ItemScript.Type.helm );

		// Weapons
		rustedSword = ItemScript.CreateInstance("Rusted Sword", "A dull and rusty sword", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		twistedBranch = ItemScript.CreateInstance("Twisted Branch", "", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		crudeBow = ItemScript.CreateInstance("Crude Bow", "", 0, 0, 0, 1, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		bronzeSword = ItemScript.CreateInstance("Bronze Sword", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		enchantedStick = ItemScript.CreateInstance("Enchanted Stick", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		averageBow = ItemScript.CreateInstance("Average Bow", "", 0, 0, 0, 1.5f, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		ironSword = ItemScript.CreateInstance("Iron Sword", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		magicWand = ItemScript.CreateInstance("Magic Wand", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		compoundBow = ItemScript.CreateInstance("Compound Bow", "", 0, 0, 0, 2, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		steelSword = ItemScript.CreateInstance("Steel Sword", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		enchantedRod = ItemScript.CreateInstance("Enchanted Rod", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		mightyBow = ItemScript.CreateInstance("Mighty Bow", "", 0, 0, 0, 3, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		scimitar = ItemScript.CreateInstance("Scimitar", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		magicRod = ItemScript.CreateInstance("Magic Rod", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		longBow = ItemScript.CreateInstance("Long Bow", "", 0, 0, 0, 4, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		greatSword = ItemScript.CreateInstance("Great Sword", "", 0, 0, 0, 6, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		enchantedStaff = ItemScript.CreateInstance("Enchanted Staff", "", 0, 0, 0, 6, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		elvenBow = ItemScript.CreateInstance("Elven Bow", "", 0, 0, 0, 6, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		claymore = ItemScript.CreateInstance("Claymore", "", 0, 0, 0, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		magicStaff = ItemScript.CreateInstance("Magic Staff", "", 0, 0, 0, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		quickBow = ItemScript.CreateInstance("Quick Bow", "", 0, 0, 0, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		Scythe = ItemScript.CreateInstance("Scythe", "", 0, 1, 0, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		runeStaff = ItemScript.CreateInstance("Rune Staff", "", 0, 0, 1, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		silverBow = ItemScript.CreateInstance("Silver Bow", "", 0, 1, 0, 7, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		katana = ItemScript.CreateInstance("Katana", "", 0, 2, 0, 9, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		archStaff = ItemScript.CreateInstance("Arch Staff", "", 0, 0, 2, 9, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		blackBow = ItemScript.CreateInstance("Black Bow", "", 0, 2, 0, 9, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		largeAsi = ItemScript.CreateInstance("Large Asi", "", 0, 2, 0, 12, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		enchantedSceptre = ItemScript.CreateInstance("Enchanted Sceptre", "", 0, 0, 2, 12, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		recurveBow = ItemScript.CreateInstance("Recurve Bow", "", 0, 2, 0, 12, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		khopesh = ItemScript.CreateInstance("Khopesh", "", 0, 3, 0, 14, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		magicSceptre = ItemScript.CreateInstance("Magic Sceptre", "", 0, 0, 3, 14, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		reinforcedBow = ItemScript.CreateInstance("Reinforced Bow", "", 0, 3, 0, 14, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		zweihander = ItemScript.CreateInstance("Zweihander", "", 0, 4, 0, 18, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		runicSceptre = ItemScript.CreateInstance("Runic Sceptre", "", 0, 0, 4, 18, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		reflexBow = ItemScript.CreateInstance("Reflex Bow", "", 0, 4, 0, 18, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		serratedSabre = ItemScript.CreateInstance("Serrated Sabre", "", 0, 5, 0, 21, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		enchantedQuarterstaff = ItemScript.CreateInstance("Enchanted Quarterstaff", "", 0, 0, 5, 21, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		daggerBow = ItemScript.CreateInstance("Dagger Bow", "", 0, 5, 0, 21, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		kaskara = ItemScript.CreateInstance("Kaskara", "", 0, 6, 0, 25, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		magicQuarterstaff = ItemScript.CreateInstance("Magic Quarterstaff", "", 0, 0, 6, 25, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		selfBow = ItemScript.CreateInstance("Self Bow", "", 0, 6, 0, 25, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		shamsir = ItemScript.CreateInstance("Shamsir", "", 0, 6, 1, 27, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		runicQuarterstaff = ItemScript.CreateInstance("Runic Quarterstaff", "", 0, 1, 6, 27, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );
		swordBow = ItemScript.CreateInstance("Sword Bow", "", 0, 6, 1, 27, 0, ItemScript.Rarity.common, ItemScript.Type.weapon );

		soulReaver = ItemScript.CreateInstance("Soul Reaver", "", 0, 6, 3, 32, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		wandOfThousandTruths = ItemScript.CreateInstance("Wand of 1,000 Truths", "", 0, 3, 6, 33, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		messenger = ItemScript.CreateInstance("Messenger", "", 1, 5, 2, 32, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		cosmicHorror = ItemScript.CreateInstance("Cosmic Horror", "", 0, 7, 3, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		necropolis = ItemScript.CreateInstance("Necropolis", "", 0, 3, 7, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		theRaven = ItemScript.CreateInstance("The Raven", "", 0, 7, 3, 35, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		worldEater = ItemScript.CreateInstance("World Eater", "", 0, 8, 4, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		livingDead = ItemScript.CreateInstance("Living Dead", "", 0, 4, 8, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		requiem = ItemScript.CreateInstance("Requiem", "", 0, 8, 4, 37, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		law = ItemScript.CreateInstance("Law", "", 1, 9, 6, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		judgement = ItemScript.CreateInstance("Judgement", "", 1, 6, 9, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
		truth = ItemScript.CreateInstance("Truth", "", 1, 9, 6, 40, 0, ItemScript.Rarity.relic, ItemScript.Type.weapon );
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
