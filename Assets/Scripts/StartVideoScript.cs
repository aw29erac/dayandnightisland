using UnityEngine;
using System.Collections;

public class StartVideoScript : MonoBehaviour {

	private MovieTexture movie;
	// Use this for initialization
	void Start () {
		
		
		
		Renderer r = GetComponent<Renderer>();
        movie = (MovieTexture)r.material.mainTexture;
		
		//GUI.DrawTexture(Rect(0,0,1920,1080),movie,ScaleMode.StretchToFill);
		
		movie.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (!movie.isPlaying) {
			Application.LoadLevel("Main");
		}
	}
}
