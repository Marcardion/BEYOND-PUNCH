using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFX : MonoBehaviour {

	public GameObject hit;

	public  void Punch(){
		
		hit.SetActive (true);


	}


	public void DisablePunch(){

		hit.SetActive (false);
	}

}
