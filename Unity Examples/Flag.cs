using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//7
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public string nextLevelName;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
