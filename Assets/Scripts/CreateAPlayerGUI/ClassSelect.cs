using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClassSelect : MonoBehaviour {

	public CreateAPlayerGUI createAPlayerGUI;

	void Start () {
		createAPlayerGUI = GameObject.Find("Main Camera").GetComponent<CreateAPlayerGUI>();
	}

	public void GetSelected(bool selected){
		if(selected){
			createAPlayerGUI.displayFunctions.selectedCharacter = this.GetComponentInChildren<Text>().text;
			createAPlayerGUI.displayFunctions.UpdateClassDescription(createAPlayerGUI.displayFunctions.selectedCharacter);
			createAPlayerGUI.displayFunctions.UpdateClassStats(createAPlayerGUI.displayFunctions.selectedCharacter);
		}
	}
}
