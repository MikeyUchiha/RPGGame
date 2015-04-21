using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		LEGS,
		FEET,
		NECK,
		EARRING,
		RING
	}
	public EquipmentTypes EquipmentType{get; set;}
}
