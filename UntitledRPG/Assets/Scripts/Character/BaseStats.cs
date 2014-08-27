public class BaseStats{
	private int _baseValue;			//Base value of the stat
	private int _buffValue;			//Value of armor/weapon buff+base
	private int _expToLevel;		//exp to level up
	private float _levelModifier;	//increases xp to level up

	public BaseStats()
	{
		_baseValue = 0;
		_buffValue = 0;
		_levelModifier = 1.1f;
		_expToLevel = 100;
	}

#region Sets Gets
	//set/get
	public int BaseValue
	{
		get{return _baseValue;}
		set{ _baseValue = value;}
	}

	public int BuffValue
	{
		get{return _buffValue;}
		set{ _buffValue = value;}
	}
	public int ExpToLevel
	{
		get{return _baseValue;}
		set{ _expToLevel = value;}
	}
	public float LevelModifier
	{
		get{return _baseValue;}
		set{ _levelModifier = value;}
	}
#endregion

	private int CalcExpToLevel()
	{
		return (int)(_expToLevel * _levelModifier);
	}

	public void LevelUp()
	{
		_expToLevel = CalcExpToLevel ();
		_baseValue++;
	}

	public int AdjustedStatValue
	{
		get{ return _baseValue + _buffValue;}
	}
}
