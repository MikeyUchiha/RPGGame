using UnityEngine;
using System.Collections;

public class LevelUp {

	public int maxPlayerLevel = 100;

	public void LevelUpCharacter(){
		//Check to see if current EXP > required EXP
		if(GameInformation.CurrentEXP > GameInformation.RequiredEXP){
			GameInformation.CurrentEXP -= GameInformation.RequiredEXP;
		}else{
			GameInformation.CurrentEXP = 0;
		}
		if(GameInformation.PlayerLevel < maxPlayerLevel){
			GameInformation.PlayerLevel += 1;
		}else{
			GameInformation.PlayerLevel = maxPlayerLevel;
		}
		//Give player stat points
		//Randomly give items
		//Give player an ability
		//Give player money
		//Determine the next amount of required EXP
		DetermineRequiredEXP();
	}

	private void DetermineRequiredEXP(){
		int playerLevel = GameInformation.PlayerLevel;
		playerLevel += 1;
		int levels = maxPlayerLevel;
		float expLevel1 = 500.0f;
		float expLevel100 = 1000000.0f;
		float temp1 = Mathf.Log(expLevel100 / expLevel1);
		float b = temp1 / (levels - 1);
		float temp2 = (Mathf.Exp(b) - 1);
		float a = (expLevel1) / temp2;
		int oldEXP = (int)(a * Mathf.Exp((float)b * (playerLevel - 1)));
		int newEXP = (int)(a * Mathf.Exp((float)b * playerLevel));
		int temp = newEXP - oldEXP;
		temp = (int)Mathf.Round((float)temp / 10.0f) * 10;
		GameInformation.RequiredEXP = temp;
	}

	private void DetermineMoneyToGive(){
		if(GameInformation.PlayerLevel <= 10){
			//Give a certain amount of money
		}
	}
}
