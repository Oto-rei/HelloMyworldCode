using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10f)
        {
            Debug.Log("落ちた");
            GetComponent<CharacterController>().enabled = false;
            this.gameObject.transform.position = new Vector3(1.37f,1f -0.02f);
            GetComponent<CharacterController>().enabled = true;

        }
    }
}
