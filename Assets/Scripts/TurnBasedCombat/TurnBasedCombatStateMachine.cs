using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	private bool hasAddedEXP = false;

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	public GameObject button;

	public BattleStates currentState{get; set;}

	// Use this for initialization
	void Start () {
		hasAddedEXP = false;
		currentState = BattleStates.START;
		CreateButton();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(currentState);
		switch(currentState){
		case (BattleStates.START):
			break;
		case (BattleStates.PLAYERCHOICE):
			break;
		case (BattleStates.ENEMYCHOICE):
			break;
		case (BattleStates.LOSE):
			break;
		case (BattleStates.WIN):
			if(!hasAddedEXP){
				IncreaseExperience.AddExperience();
				hasAddedEXP = true;
			}
			break;
		}
	}

	void CreateButton(){
		GameObject canvas = GameObject.Find("Canvas");
		GameObject nextStateButton = Instantiate(button);
		RectTransform myTransform = nextStateButton.GetComponent<RectTransform>();
		myTransform.SetParent(canvas.transform, false);
		nextStateButton.GetComponentInChildren<Text>().text = "Change State";
		nextStateButton.GetComponent<Button>().onClick.AddListener(() => {ChangeState();});
	}

	private void ChangeState(){
		currentState = (BattleStates)(((int)currentState + 1) % 5);
	}
}
