using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {


	public enum BattleStates {
		START,
		PLAYERCHOICE,
		PLAYERANIMATE,
		ENEMYCHOICE,
		ENEMYANIMATE,
		LOSE,
		WIN
	}
		
	private BattleStates currentState;

	void Awake (){
		currentState = BattleStates.START;
	}

	void Start (){
		//currentState = BattleStates.START;
	}


	void Update (){
		Debug.Log (currentState);
		switch (currentState) {
		case(BattleStates.START):

			//Setup battle function HERE
			if(currentState == BattleStates.START){
				currentState = BattleStates.PLAYERCHOICE;
			}
			break;

		case(BattleStates.PLAYERCHOICE):
			//Attacks and players options go HERE.
			break;

		case(BattleStates.PLAYERANIMATE):
			break;

		case(BattleStates.ENEMYCHOICE):
			break;

		case(BattleStates.ENEMYANIMATE):
			break;

		case(BattleStates.LOSE):
			break;

		case(BattleStates.WIN):
			break;
		}
	}


	void OnGUI() {
		
		if (GUI.Button (new Rect (350, 390, 700, 50), "Attack 1")) {
			if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.PLAYERANIMATE;
			}
			print ("attack 1");
		}
		if (GUI.Button (new Rect (350, 445, 700, 50), "Attack 2")) {
			if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.PLAYERANIMATE;
			}
			print ("attack 2");
		}
		if (GUI.Button (new Rect (350, 500, 700, 50), "Attack 3")) {
			if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.PLAYERANIMATE;
			}
			print ("attack 3");
		}
		if (GUI.Button (new Rect (350, 555, 700, 50), "Attack 4")) {
			if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.PLAYERANIMATE;
			}
			print ("attack 4");
		}
	}
}


