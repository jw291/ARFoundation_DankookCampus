using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitPanelButton : MonoBehaviour
{
    public Button Exitpanelbtn;
    public GameObject go;
    // Update is called once per frame
    void Start()
    {
        Button btn = Exitpanelbtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        Debug.Log("나가기 버튼 클릭!!");
        Destroy(go);
    }
}
