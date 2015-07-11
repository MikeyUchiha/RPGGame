using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	
	public static string PlayerName{get; set;}
	public static int PlayerLevel{get; set;}
	public static BaseCharacterClass PlayerClass{get; set;}

	public static int CurrentEXP{get; set;}
	public static int RequiredEXP{get; set;}
	public static int Gold{get; set;}

	public static int Strength{get; set;}
	public static int Agility{get; set;}
	public static int Dexterity{get; set;}
	public static int Vitality{get; set;}
	public static int Intelligence{get; set;}
	public static int Luck{get; set;}

	public static BaseEquipment EquipmentOne{get; set;}
}
