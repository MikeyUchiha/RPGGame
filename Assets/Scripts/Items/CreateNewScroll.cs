using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {

	private BaseScroll newScroll;

	void Start () {
		CreateScroll();
		Debug.Log(newScroll.ItemName);
		Debug.Log(newScroll.ItemDescription);
		Debug.Log(newScroll.ScrollType.ToString());
		Debug.Log("Item ID: " + newScroll.ItemID.ToString());
		Debug.Log("Strength: " + newScroll.Strength.ToString());
		Debug.Log("Agility: " + newScroll.Agility.ToString());
		Debug.Log("Dexterity: " + newScroll.Dexterity.ToString());
		Debug.Log("Vitality: " + newScroll.Vitality.ToString());
		Debug.Log("Intelligence: " + newScroll.Intelligence.ToString());
		Debug.Log("Luck: " + newScroll.Luck.ToString());
	}

	private void CreateScroll(){
		newScroll = new BaseScroll();

		ChooseScrollType();
		SetScrollName();
		newScroll.ItemID = Random.Range(1,101);
		newScroll.ItemDescription = "This item is a " + newScroll.ItemName;
	}
	
	private void ChooseScrollType(){
		int valuesCount = System.Enum.GetValues(typeof(BaseScroll.ScrollTypes)).Length;
		int randomTemp = Random.Range(0,valuesCount);
		newScroll.ScrollType = (BaseScroll.ScrollTypes)randomTemp;
	}
	
	private void SetScrollName(){
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.STRENGTH){
			newScroll.ItemName = "Strength Potion";
			newScroll.Strength = 10;
		}
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.AGILITY){
			newScroll.ItemName = "Agility Potion";
			newScroll.Agility = 10;
		}
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.DEXTERITY){
			newScroll.ItemName = "Dexterity Potion";
			newScroll.Dexterity = 10;
		}
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.VITALITY){
			newScroll.ItemName = "Vitality Potion";
			newScroll.Vitality = 10;
		}
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.INTELLIGENCE){
			newScroll.ItemName = "Intelligence Potion";
			newScroll.Intelligence = 10;
		}
		if(newScroll.ScrollType == BaseScroll.ScrollTypes.LUCK){
			newScroll.ItemName = "Luck Potion";
			newScroll.Luck = 10;
		}
	}

}
