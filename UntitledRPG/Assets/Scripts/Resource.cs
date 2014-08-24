public class Resource : ModifiedStats{

	private int _curValue;

	public Resource()
	{
		_curValue = 0;
		ExpToLevel = 50;
		LevelModifier = 1.1f;

	}
	public int CurValue
	{
		get{
				if (_curValue > AdjustedStatValue)
						_curValue = AdjustedStatValue;
	
				return _curValue;
			}
		set{ _curValue = value;}
	}
}

public enum ResourceName{
	Health,
	Rage,
	Dark_Energy,
	Stamina
}

