using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class GameSceneManager : MonoBehaviour
{
    public string sceneName;
    public Fungus.Flowchart flowchart;
    public GameObject canption;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canption.activeSelf)
        {
            SceneManager.LoadScene(sceneName);
            flowchart.SetBooleanVariable("Start", false);
            canption.SetActive(false);
        }
    }
}
