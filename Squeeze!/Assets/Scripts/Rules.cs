using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rules : MonoBehaviour {

	public Text rules;

	void Start()
	{
		rules.enabled = false;
	}

	//function to switch to the Main Scene for game play 
	public void Play()
	{
		if (rules.enabled) {
			rules.enabled = false;
		}
		else {
			rules.enabled = true;
		}
	}
}

