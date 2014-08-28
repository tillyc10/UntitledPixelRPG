using UnityEngine;
using System.Collections;


public class Skills :  MonoBehaviour{
	private bool _known;

	public Skills()
	{
		_known = false;
	}

	public bool Known
	{
		get{return _known;}
		set{_known = value;}
	}
}

public enum SkillName {
	Attack,
	Execution,
	Blood_Ritual,
	Second_Strike,
	Destruction,
	Summon_Skeleton,
	Life_Drain,
	Necrotic_Aura,
	Summon_Demon,
	Aimed_Shot,
	Marksmanship,
	Quick_Shot,
	Full_Draw
}