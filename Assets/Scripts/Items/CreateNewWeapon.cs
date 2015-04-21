using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
	private string[] weaponNames = new string[5] { "Bronze", "Silver", "Gold", "Mithril", "Adamantite"};

	void Start(){
		CreateWeapon();
		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.WeaponType.ToString());
		Debug.Log("Item ID: " + newWeapon.ItemID.ToString());
		Debug.Log("Attack: " + newWeapon.Attack.ToString());
	}

	private void CreateWeapon(){
		newWeapon = new BaseWeapon();

		// Type of Weapon
		ChooseWeaponType();
		// Assign name to weapon
		string tempName = UppercaseFirst(newWeapon.WeaponType.ToString());
		newWeapon.ItemName = weaponNames[Random.Range(0,weaponNames.Length)] + " " + tempName;
		// Create a weapon description
		newWeapon.ItemDescription = "This is a " + newWeapon.ItemName;
		// Weapon ID
		newWeapon.ItemID = Random.Range(1,101);
		// Stats
		newWeapon.Attack = Random.Range (1,11);
		// Spell Effect ID
		newWeapon.SpellEffectID = Random.Range(1,101);
	}

	private void ChooseWeaponType(){
		int valuesCount = System.Enum.GetValues(typeof(BaseWeapon.WeaponTypes)).Length;
		int randomTemp = Random.Range(0,valuesCount);
		newWeapon.WeaponType = (BaseWeapon.WeaponTypes)randomTemp;
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
