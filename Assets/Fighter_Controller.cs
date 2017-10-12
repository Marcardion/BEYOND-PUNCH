using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Controller : MonoBehaviour {

	[SerializeField] Animator fighterAnim;

	bool isActive = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("q")) 
		{
			Punch ();
		}

		if (Input.GetKeyDown ("w")) 
		{
			Grab ();
		}

		if (Input.GetKeyDown ("e")) 
		{
			Block ();
		}
	}

	IEnumerator ReturnToIdle()
	{
		yield return new WaitForSeconds (0.7f);
		fighterAnim.SetTrigger ("Return");
		isActive = true;
	}

	public void Punch()
	{
		if (isActive) {
			fighterAnim.SetTrigger ("Punch");
			isActive = false;
			StartCoroutine (ReturnToIdle ());
		}
	}

	public void Grab()
	{
		if (isActive) {
			fighterAnim.SetTrigger ("Grab");
			isActive = false;
			StartCoroutine (ReturnToIdle ());
		}
	}

	public void Block()
	{
		if (isActive) {
			fighterAnim.SetTrigger ("Block");
			isActive = false;
			StartCoroutine (ReturnToIdle ());
		}
	}
}
