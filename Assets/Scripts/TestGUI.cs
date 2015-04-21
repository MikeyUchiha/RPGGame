using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TestGUI : MonoBehaviour {

	private List<BaseCharacterClass> characterClasses = new List<BaseCharacterClass>{ new BaseSquireClass(), new BaseMageClass()};

	public Font font;
	public GameObject label;
	public GameObject button;

	// Use this for initialization
	void Start () {
		CreateLabels();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateLabels() {
		GameObject panel = GameObject.Find("Panel");

		for(int i = 0; i < characterClasses.Count; i++) {
			GameObject nameLabel = Instantiate(label);
			GameObject descriptionLabel = Instantiate(label);
			GameObject strengthValue = Instantiate(label);
			GameObject agilityValue = Instantiate(label);
			GameObject dexterityValue = Instantiate(label);
			GameObject vitalityValue = Instantiate(label);
			GameObject intelligenceValue = Instantiate(label);
			GameObject luckValue = Instantiate(label);
			nameLabel.name = characterClasses[i].CharacterClassName + " Label";
			descriptionLabel.name = characterClasses[i].CharacterClassName + " Description";
			nameLabel.transform.SetParent(panel.transform, false);
			descriptionLabel.transform.SetParent(panel.transform, false);
			strengthValue.transform.SetParent(panel.transform, false);
			agilityValue.transform.SetParent(panel.transform, false);
			dexterityValue.transform.SetParent(panel.transform, false);
			vitalityValue.transform.SetParent(panel.transform, false);
			intelligenceValue.transform.SetParent(panel.transform, false);
			luckValue.transform.SetParent(panel.transform, false);
			nameLabel.GetComponent<Text>().text = characterClasses[i].CharacterClassName;
			descriptionLabel.GetComponent<Text>().text = characterClasses[i].CharacterClassDescription;
			strengthValue.GetComponent<Text>().text = "Strength: " + characterClasses[i].Strength.ToString();
			agilityValue.GetComponent<Text>().text = "Agility " + characterClasses[i].Agility.ToString();
			dexterityValue.GetComponent<Text>().text = "Dexterity: " + characterClasses[i].Dexterity.ToString();
			vitalityValue.GetComponent<Text>().text = "Vitality: " + characterClasses[i].Vitality.ToString();
			intelligenceValue.GetComponent<Text>().text = "Intelligence: " + characterClasses[i].Intelligence.ToString();
			luckValue.GetComponent<Text>().text = "Luck: " + characterClasses[i].Luck.ToString();
		}
	}
}
