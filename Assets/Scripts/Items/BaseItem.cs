using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseItem {

	public string ItemName{get; set;}
	public string ItemDescription{get; set;}
	public int ItemID{get; set;}
	public enum ItemTypes{
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}
	public ItemTypes ItemType{get; set;}
}
