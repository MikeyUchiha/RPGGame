using UnityEngine;
using System.Collections;

public class BaseSquireClass : BaseCharacterClass {

	public BaseSquireClass() {
		CharacterClassName = "Squire";
		CharacterClassDescription = "A melee fighter who specializes in weapons.";

		Strength += 3;
		Agility += 3;
		Vitality += 5;
	}
}
