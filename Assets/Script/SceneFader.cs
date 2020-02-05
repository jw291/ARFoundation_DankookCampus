using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour
{

	public Image black;
	public GameObject img;
	public Animator anim;

   
    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

   

    IEnumerator FadeOut(string scene)
    {
		img.SetActive(true);

		anim.SetBool("fade",true);
		yield return new WaitUntil(()=>black.color.a==1);
      
        SceneManager.LoadScene(scene);
    }

}