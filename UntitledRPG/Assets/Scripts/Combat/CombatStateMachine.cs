using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour 
{
	private bool hasAddedXP = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();

	public enum BattleStates 
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		CALCDAMAGE,
		ITEM,
		CLEANSE,
		RUN,
		LOSE,
		WIN
	}
		
	private BattleStates currentState;


		// Use this for initialization
		void Start ()
		{
			hasAddedXP = false;
			currentState = BattleStates.START;
		}
	
		// Update is called once per frame
		void Update ()
		{
		Debug.Log (currentState);

			switch (currentState) {
				case (BattleStates.START):
				// Setup Battle Function Here
				// creates enemy

						break;
				
				case (BattleStates.PLAYERCHOICE): // player choses attack
						break;
				
				case (BattleStates.ENEMYCHOICE): // Need to create the enemy AI
						break;

				case (BattleStates.CALCDAMAGE): // calculate damage done taking in consideration the attack and stats
						break;

				case (BattleStates.ITEM):
						break;

				case (BattleStates.CLEANSE):
						break;
					
				case (BattleStates.RUN):
						break;
						
				case (BattleStates.LOSE):
						break;

				case (BattleStates.WIN):
				// need to add this but these dont exist elsewhere yet
					//if (!hasAddedXP)
					//{
						//IncreaseExperience.AddExperience();
						// hasAddedXP = True
					//}
						break;

		}
	}
}

