using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaUIController : MonoBehaviour
{
    public Animator anim;
    private bool tri;
    // Start is called before the first frame update
    void Start()
    {
        tri = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (tri == true)
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player");
                anim.SetBool("OpenUI", true);
                tri = false;
            }
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        tri = true;
        anim.SetBool("OpenUI", false);
    }
}
