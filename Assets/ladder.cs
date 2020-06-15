using UnityEngine;
using System.Collections;

public class ladder : MonoBehaviour {
	
	public bool State1 = true;
	public bool State2 = true;
	public bool State3 = false;
	
	void OnTriggerStay () {
		if(Input.GetKeyDown(KeyCode.E)){
			State1 = !State1;
			State2 = !State2;
			State3 = !State3;
			//GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMotor>().enabled = State1;
			//GameObject.FindGameObjectWithTag("Player").GetComponent<FPSInputController>().enabled = State2;
			GameObject.FindGameObjectWithTag("Player").GetComponent<system>().enabled = State3;
		}
	}
	
	void OnTriggerExit () {
		//GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMotor>().enabled = true;
		//GameObject.FindGameObjectWithTag("Player").GetComponent<FPSInputController>().enabled = true;
		GameObject.FindGameObjectWithTag("Player").GetComponent<system>().enabled = false;
	}
}
