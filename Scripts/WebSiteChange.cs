using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebSiteChange : MonoBehaviour
{
    [SerializeField]
    string  URL;
    GameObject canption;
     // Start is called before the first frame update
    void Start()
    {
        canption =transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&canption.activeSelf)
        {
            var uri=new System.Uri(URL);
            Application.OpenURL(uri.AbsoluteUri);
            canption.SetActive(false);
        }
    }

}
