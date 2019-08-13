using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colission : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidas;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D coli)
    {
        if (coli.gameObject.tag == "Rash")
        {
            SceneManager.LoadScene(1);
            Destroy(coli.gameObject);
        }
           
        
    }
    private void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject.tag == "Rash")
        {
            SceneManager.LoadScene(1);
            Destroy(coli.gameObject);
        }
    }
}
