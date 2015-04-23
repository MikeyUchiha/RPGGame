using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation(){
		GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
		GameInformation.Agility = PlayerPrefs.GetInt("AGILITY");
		GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
		GameInformation.Vitality = PlayerPrefs.GetInt("VITALITY");
		GameInformation.Intelligence = PlayerPrefs.GetInt("INTELLIGENCE");
		GameInformation.Luck = PlayerPrefs.GetInt("LUCK");

		if(PlayerPrefs.GetString("EQUIPMENTITEM1") != null){
			GameInformation.EquipmentOne = (BaseEquipment)PlayerInfoSerialization.Load("EQUIPMENTITEM1");
		}
	}
}
