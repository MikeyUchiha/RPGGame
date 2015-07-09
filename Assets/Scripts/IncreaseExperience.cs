using UnityEngine;
using System.Collections;

public static class IncreaseExperience {

	private static int expToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience(){
		expToGive  = GameInformation.PlayerLevel * 100;
		GameInformation.CurrentEXP += expToGive;
		CheckToSeeIfPlayerLeveled();
		Debug.Log(expToGive);
	}

	public static void AddExperienceFromBattleLoss(){
		expToGive = GameInformation.PlayerLevel * 10;
		GameInformation.CurrentEXP += expToGive;
		CheckToSeeIfPlayerLeveled();
		Debug.Log(expToGive);
	}

	private static void CheckToSeeIfPlayerLeveled(){
		if(GameInformation.CurrentEXP >= GameInformation.RequiredEXP){
			// Player has leveled up
			levelUpScript.LevelUpCharacter();
		}
	}
	
}
