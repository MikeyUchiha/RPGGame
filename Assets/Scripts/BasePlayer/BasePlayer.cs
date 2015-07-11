using UnityEngine;
using System.Collections;

public class BasePlayer {

	public string PlayerName{get; set;}
	public int PlayerLevel{get; set;}
	public BaseCharacterClass PlayerClass{get; set;}

	public int CurrentEXP{get; set;}
	public int RequiredEXP{get; set;}

	public int Gold{get; set;}

	// Base Stats
	public int Strength{get; set;}
	public int Agility{get; set;}
	public int Dexterity{get; set;}
	public int Vitality{get; set;}
	public int Intelligence{get; set;}
	public int Luck{get; set;}

	// Derived Stats
	public int HealthPoints{get; set;}
	public int MagicPoints{get; set;}
	public int Attack{get; set;}
	public int Defense{get; set;}
	public int MagicAttack{get; set;}
	public int MagicDefense{get; set;}
	public int Accuracy{get; set;}
	public int CritChance{get; set;}
	public int DodgeChance{get; set;}
}
