using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] equipmentNames = new string[5] { "Bronze", "Silver", "Gold", "Mithril", "Adamantite"};

	void Start(){
		CreateEquipment();
		Debug.Log(newEquipment.ItemName);
		Debug.Log(newEquipment.ItemDescription);
		Debug.Log(newEquipment.EquipmentType.ToString());
		Debug.Log("Item ID: " + newEquipment.ItemID.ToString());
		Debug.Log("Defense: " + newEquipment.Defense.ToString());
	}

	private void CreateEquipment(){
		newEquipment = new BaseEquipment();

		string tempName = UppercaseFirst(newEquipment.EquipmentType.ToString());
		newEquipment.ItemName = equipmentNames[Random.Range(0,equipmentNames.Length)] + " " + tempName + " Armor";
		newEquipment.ItemDescription = "This is a " + newEquipment.ItemName;
		newEquipment.ItemID = Random.Range(1,101);
		newEquipment.Defense = Random.Range (1,11);
	}

	private void ChooseEquipmentType(){
		int valuesCount = System.Enum.GetValues(typeof(BaseEquipment.EquipmentTypes)).Length;
		int randomTemp = Random.Range(0,valuesCount);
		newEquipment.EquipmentType = (BaseEquipment.EquipmentTypes)randomTemp;
	}

	string UppercaseFirst(string s)
	{
		// Check for empty string.
		if (string.IsNullOrEmpty(s))
		{
			return string.Empty;
		}
		// Return char and concat substring.
		string tempstring = s.Substring(1);
		return  s.Substring(0,1) + tempstring.ToLower();
		//return s.ToLower();
	}
}
