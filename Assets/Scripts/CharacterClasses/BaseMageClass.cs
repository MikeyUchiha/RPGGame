using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass() {
		CharacterClassName = "Mage";
		CharacterClassDescription = "A magic wielder who deals magic damage from afar.";
		
		Agility += 3;
		Vitality += 3;
		Intelligence += 5;
	}
}
