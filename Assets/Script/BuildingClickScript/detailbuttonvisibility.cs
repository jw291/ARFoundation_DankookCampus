using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class detailbuttonvisibility : MonoBehaviour {
	public void toggleVisibililty()
	{
		Renderer rend = gameObject.GetComponent<Renderer>();

		if(rend.enabled){
			rend.enabled = false;
		}else{
			rend.enabled = true;
		}
	}
}
