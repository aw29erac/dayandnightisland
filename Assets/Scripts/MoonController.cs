using UnityEngine;
using System.Collections;

public class MoonController : MonoBehaviour {

	public int MoonCycleLength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float angle = Time.frameCount * 360.0f / MoonCycleLength;
		
		transform.localEulerAngles = new Vector3(angle,0,0);
	
	}
}
