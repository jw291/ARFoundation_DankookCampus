using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setfade : MonoBehaviour {
	public GameObject img;
    
	public void SetFadeImage(){
		img.SetActive(false);
	}

	public void GetFadeImage(){
		img.SetActive(true);
	}
}
