using UnityEngine;
using System.Collections;



public class CenaCubeController : MonoBehaviour {

	public Transform CenaCube;
	public float height;
	private int counter;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		height = transform.position.y;
	 
		if (height < -400.0) {
			Destroy(gameObject);
		}
		
		counter++;
		
		if (Random.value > 0.999f || counter == 600) {
			Vector3 pos = new Vector3(520,300,490);
			Instantiate(CenaCube, pos + (Random.insideUnitSphere * 10), Quaternion.identity);
			//counter = 0;
		}
	}
}
