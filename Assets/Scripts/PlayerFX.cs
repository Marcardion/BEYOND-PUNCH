using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFX : MonoBehaviour {

	public GameObject hit;
	public GameObject parry;
	public GameObject hold;

	public  void Punch(){
		
		hit.SetActive (true);
	}


	public void DisablePunch(){

		hit.SetActive (false);
	}


	public  void Block(){

		parry.SetActive (true);
	}


	public void DisableBlock(){

		parry.SetActive (false);
	}


	public  void Grab(){

		hold.SetActive (true);
	}


	public void DisableGrab(){

		hold.SetActive (false);
	}

}
