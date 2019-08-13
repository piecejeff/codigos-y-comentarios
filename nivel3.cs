using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel3 : MonoBehaviour
{
    public GameObject puerta;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
            col.gameObject.SetActive(false);
        SceneManager.LoadScene(2);
    }
}
