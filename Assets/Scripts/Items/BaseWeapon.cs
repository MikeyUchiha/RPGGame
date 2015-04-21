using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM,
		AXE
	}
	public WeaponTypes WeaponType{get; set;}
	public int SpellEffectID{get; set;}
}
