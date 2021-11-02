using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene2 : MonoBehaviour
{
    [SerializeField] private string scene;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Coin1") & GameObject.Find("Coin2") == null)
        {
            SceneManager.LoadScene(scene);
        }
    }

}
