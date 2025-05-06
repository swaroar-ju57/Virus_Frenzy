using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ChangeSceen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeingScene", (float)(GetComponent<VideoPlayer>().clip.length + .5));
    }

    void ChangeingScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
