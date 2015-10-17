using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayCreatePlayerFunctions : MonoBehaviour {

	private int classSelection;
	//private string[] classSelectionNames = new string[] {"Squire", "Mage", "Monk", "Thief", "Bowman", "Page"};
	public GameObject CreateAPlayerGUIPrefab;
	public string selectedCharacter;

	public void DisplayClassSelection(){
		// A list of toggle buttons and each button will be a different class
		GameObject canvas = GameObject.Find("Canvas");
		GameObject createAPlayerGUI = Instantiate(CreateAPlayerGUIPrefab) as GameObject;
		RectTransform myTransform = createAPlayerGUI.GetComponent<RectTransform>();
		myTransform.SetParent(canvas.transform, false);
	}

	public string FindClassDescription(string characterClass){
		if(characterClass == "Squire"){
			BaseCharacterClass tempClass = new BaseSquireClass();
			return tempClass.CharacterClassDescription;
		}else if(characterClass == "Mage"){
			BaseCharacterClass tempClass = new BaseMageClass();
			return tempClass.CharacterClassDescription;
		}
		return "No class selected.";
	}

	public string FindClassStats(string characterClass){
		if(characterClass == "Squire"){
			BaseCharacterClass tempClass = new BaseSquireClass();
			string tempStats = "Strength: " + tempClass.Strength
				+ "\n" + "Agility: " + tempClass.Agility
				+ "\n" + "Dexterity: " + tempClass.Dexterity
				+ "\n" + "Vitality: " + tempClass.Vitality
				+ "\n" + "Intelligence: " + tempClass.Intelligence;
			return tempStats;
		}else if(characterClass == "Mage"){
			BaseCharacterClass tempClass = new BaseMageClass();
			string tempStats = "Strength: " + tempClass.Strength
				+ "\n" + "Agility: " + tempClass.Agility
				+ "\n" + "Dexterity: " + tempClass.Dexterity
				+ "\n" + "Vitality: " + tempClass.Vitality
				+ "\n" + "Intelligence: " + tempClass.Intelligence;
			return tempStats;
		}
		return "No class selected.";
	}

	public void UpdateClassDescription(string characterClass){
		Text classDescriptionTextObject = GameObject.Find("ClassDescriptionUILayout").GetComponent<Text>();
		classDescriptionTextObject.text = FindClassDescription(characterClass);
	}

	public void UpdateClassStats(string characterClass){
		Text classStatsTextObject = GameObject.Find("ClassStatsUILayout").GetComponent<Text>();
		classStatsTextObject.text = FindClassStats(characterClass);
	}

	public void DisplayStatAllocation(){
		// A list of stats with plus and minus buttons to add stats
		// Logic to make sure the player cannot add more than stats given
	}

	public void DisplayFinalSetup(){
		// Name
		// Gender
		// Add a description to character
	}

	public void DisplayMainItems(){

	}
}
