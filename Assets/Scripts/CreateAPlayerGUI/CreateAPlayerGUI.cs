using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates{
		CLASSSELECTION,	// Display all class types
		STATALLOCATION,	// Allocate stats
		FINALSETUP		// Add name and misc items
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () {
		switch(currentState){
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}
	}

	void CreateUI(){

	}

	void ChangeUI(){
		if(currentState == CreateAPlayerStates.CLASSSELECTION){
			// Display class selection function
			displayFunctions.DisplayClassSelection();
		}
		if(currentState == CreateAPlayerStates.STATALLOCATION){
			// Display stat allocation function
			displayFunctions.DisplayStatAllocation();
		}
		if(currentState == CreateAPlayerStates.FINALSETUP){
			// Display final setup function
			displayFunctions.DisplayFinalSetup();
		}
	}
}
