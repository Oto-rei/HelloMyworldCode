using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canption : MonoBehaviour
{
    public GameObject canption;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canption.SetActive(true);
            Debug.Log("当たった");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("離れた");
            canption.SetActive(false);
        }
    }
}
