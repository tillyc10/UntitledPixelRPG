public class Attributes : BaseStats {

	public Attributes()
	{
		ExpToLevel = 50;
		LevelModifier = 1.05f;
	}
}

public enum AttributeName
{
	STR,
	DEX,
	INT
}