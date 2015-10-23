using UnityEngine;
using System.Collections;

public class SunController : MonoBehaviour {

	public int DayLength;
	private float DayProgress;
	private Light li;
	
	public int begin_dusk;
	public int end_dawn;
	
	private Color sun_midday;
	private Color sun_dusk;
	private Color sun_dawn;

	// Use this for initialization
	void Start () {
		//DayProgress = (float) Time.frameCount / (float) DayLength % 1;
		DayProgress = 0.0f;
		li = GetComponent<Light>();
		
		sun_midday = Color.white;
		sun_dusk = Color.red;
		sun_dawn = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
		
		DayProgress = (DayProgress + 1.0f/DayLength * Time.deltaTime) % 1.0f;
		
		
		
		float angle = DayProgress * 360.0f - 90.0f;
		
		transform.localEulerAngles = new Vector3(angle,0,0);
		
		
		float dusk_begin = (float) begin_dusk /24.0f;
		float dawn_end = (float) end_dawn / 24.0f;
		
		if (DayProgress > dusk_begin) {
				li.color = Color.Lerp(sun_midday,sun_dusk,(DayProgress-dusk_begin)*4);
		}
		
		if (DayProgress > 0.8) {
			li.intensity = 1.0f - ((DayProgress-0.8f)*5);
		}
		
		if (DayProgress < dawn_end) {
				li.color = Color.Lerp(sun_dawn,sun_midday,DayProgress/dawn_end);
		}
		
		if (DayProgress < 0.2) {
			li.intensity = DayProgress * 5;
		}
		
	
	}
}
