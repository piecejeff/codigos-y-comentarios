using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeNivel : MonoBehaviour
{
    private bool PlayerInLevel;
    public string levelCarga;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInLevel == true)
        {
            SceneManager.LoadScene(levelCarga);
        }
    }

    void OnTriggerEnter2D(Collider2D Personaje)
    {
        if (Personaje.name == "Rash")
        {
            PlayerInLevel = true;
            Debug.Log("Entro al portal");
        }

    }
    void OnTriggerExit2D(Collider2D Personaje)
    {
        if (Personaje.name == "Rash")
        {
            PlayerInLevel = false;
            Debug.Log("Salgo del portal");
        }
    }
}