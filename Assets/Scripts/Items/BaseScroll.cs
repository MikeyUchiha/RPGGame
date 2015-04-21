using UnityEngine;
using System.Collections;

public class BaseScroll : BaseStatItem {

	public enum ScrollTypes{
		STRENGTH,
		AGILITY,
		DEXTERITY,
		VITALITY,
		INTELLIGENCE,
		LUCK
	}
	public ScrollTypes ScrollType{get; set;}

	public int SpellEffectID{get; set;}
}
