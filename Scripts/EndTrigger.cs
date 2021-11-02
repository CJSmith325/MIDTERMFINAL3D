using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GM gameManager; 
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
