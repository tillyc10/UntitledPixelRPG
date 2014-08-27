using UnityEngine;
using System.Collections;
using System;		//access enum class

public class BaseCharacter : MonoBehaviour {
	private string _name;
	private int _level;
	private uint _freeExp;

	private Attribute[] _primaryAttribute;
	private Resource[] _resource;
	private Skills[] _skills;


	public void Awake()
	{
		_name = string.Empty;
		_level = 0;
		_freeExp = 0;

		_primaryAttribute = new Attribute[Enum.GetValues(typeof(AttributeName)).Length];
		_resource = new Resource[Enum.GetValues (typeof(ResourceName)).Length];
		_skills = new Skills[Enum.GetValues (typeof(SkillName)).Length];
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string Name 
	{
		get{ return _name;}
		set{ _name = value;}
	}

	public int Level
	{
		get{ return _level;}
		set{ _level = value;}
	}

	public uint FreeExp
	{
		get{ return _freeExp;}
		set{_freeExp = value;}
	}

	public void AddExp(uint exp)
	{
		_freeExp += exp;

		CalcLevel ();
	}


	public void CalcLevel()
	{

	}

	private void SetupAttributes()
	{
		for (int cnt = 0; cnt < _primaryAttribute.Length; cnt++) 
		{
			//_primaryAttribute[cnt] = new Attribute();
		}
	}

	private void SetupResources()
	{
		for (int cnt = 0; cnt < _resource.Length; cnt++) 
		{
			_resource[cnt] = new Resource();
		}
	}

	private void SetupSkills()
	{
		for (int cnt = 0; cnt < _skills.Length; cnt++) 
		{
			_skills[cnt] = new Skills();
		}
	}

	public Attribute GetPrimaryAttribute(int index)
	{
		return _primaryAttribute [index];
	}
	public Resource GetResource(int index)
	{
		return _resource [index];
	}
	public Skills GetSkills(int index)
	{
		return _skills [index];
	}

	private void SetupResourceModifiers()
	{
		//health
		ModifyingAttribute health = new ModifyingAttribute ();
		//health.attribute = GetPrimaryAttribute ((int)AttributeName.STR);
		health.ratio = .5f;

		GetResource ((int)ResourceName.Health).AddModifier (health);
	}
	
}
