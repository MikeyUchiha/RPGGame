﻿using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt("AGILITY", GameInformation.Agility);
		PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
		PlayerPrefs.SetInt("VITALITY", GameInformation.Vitality);
		PlayerPrefs.SetInt("INTELLIGENCE", GameInformation.Intelligence);
		PlayerPrefs.SetInt("LUCK", GameInformation.Luck);
		PlayerPrefs.SetInt("GOLD", GameInformation.Gold);

		PlayerInfoSerialization.Save("PLAYERCLASS", GameInformation.PlayerClass);

		if(GameInformation.EquipmentOne != null){
			PlayerInfoSerialization.Save("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}

		Debug.Log("SAVED ALL INFORMATION");
	}
}
