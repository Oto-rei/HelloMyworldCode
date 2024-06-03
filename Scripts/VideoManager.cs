using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;


    public GameObject canption;

    void Start()
    {
        /*AddListener(関数)
        {
            this.videoPlayer.Play();
            canption.SetActive(false);
        });*/


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&canption.activeSelf)
        {
            this.videoPlayer.Play();
            Debug.Log("Play");
            canption.SetActive(false);
        }
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Invisible");
        this.videoPlayer.Stop();
    }
}
