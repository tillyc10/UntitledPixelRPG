using System.Collections.Generic;

public class ModifiedStats : BaseStats{

	private List<ModifyingAttribute> _mods; //List of Attributes the modify this stat
	private int _modValue;					//store amount added to baseValue from the modifiers

	public ModifiedStats()
	{
		_mods = new List<ModifyingAttribute> ();
		_modValue = 0;
	}
	public void AddModifier( ModifyingAttribute mod)
	{
		_mods.Add (mod);
	}

	private void CalcModValue()
	{
		_modValue = 0;

		if (_mods.Count > 0)
						foreach (ModifyingAttribute att in _mods)
								_modValue += (int)(att.attribute.AdjustedStatValue * att.ratio);
	}

	public new int AdjustedStatValue
	{
		get{ return BaseValue + BuffValue + _modValue; }
	}

	public void Update()
	{
		CalcModValue ();
	}
}

public struct ModifyingAttribute
{
	public Attributes attribute;
	public float ratio;
}
