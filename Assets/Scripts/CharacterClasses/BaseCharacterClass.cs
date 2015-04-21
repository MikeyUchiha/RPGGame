using UnityEngine;
using System.Collections;

public class BaseCharacterClass {

	public string CharacterClassName{get; set;}
	public string CharacterClassDescription{get; set;}
	// Base Stats
	public int Strength{get; set;}
	public int Agility{get; set;}
	public int Dexterity{get; set;}
	public int Vitality{get; set;}
	public int Intelligence{get; set;}
	public int Luck{get; set;}
	// Derived Stats
	public int HitPoints{get; set;}
	public int MagicPoints{get; set;}
	public int Attack{get; set;}
	public int Defense{get; set;}
	public int MagicAttack{get; set;}
	public int MagicDefense{get; set;}
	public int Accuracy{get; set;}
	public int CritChance{get; set;}
	public int DodgeChance{get; set;}

	public BaseCharacterClass() {
		Strength = 15;
		Agility = 15;
		Dexterity = 15;
		Vitality = 15;
		Intelligence = 15;
		Luck = 15;
	}
}
