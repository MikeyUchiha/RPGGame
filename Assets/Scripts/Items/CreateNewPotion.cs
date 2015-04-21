using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	void Start () {
		CreatePotion();
		Debug.Log(newPotion.ItemName);
		Debug.Log(newPotion.ItemDescription);
		Debug.Log(newPotion.PotionType.ToString());
		Debug.Log("Item ID: " + newPotion.ItemID.ToString());
		Debug.Log("HP: " + newPotion.HealthPoints.ToString());
		Debug.Log("MP: " + newPotion.MagicPoints.ToString());
	}

	private void CreatePotion(){
		newPotion = new BasePotion();

		ChoosePotionType();
		SetPotionName();
		newPotion.ItemID = Random.Range(1,101);
		newPotion.ItemDescription = "This item is a " + newPotion.ItemName;
	}

	private void ChoosePotionType(){
		int valuesCount = System.Enum.GetValues(typeof(BasePotion.PotionTypes)).Length;
		int randomTemp = Random.Range(0,valuesCount);
		newPotion.PotionType = (BasePotion.PotionTypes)randomTemp;
	}

	private void SetPotionName(){
		if(newPotion.PotionType == BasePotion.PotionTypes.HEALTH){
			newPotion.ItemName = "Health Potion";
			newPotion.HealthPoints = 30;
		}
			
		if(newPotion.PotionType == BasePotion.PotionTypes.MANA){
			newPotion.ItemName = "Mana Potion";
			newPotion.MagicPoints = 30;
		}
			
	}
}
