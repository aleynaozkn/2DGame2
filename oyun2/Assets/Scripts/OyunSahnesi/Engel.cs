using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="karakter")
        {
            SceneManager.LoadScene(0);
            YöneticiScript.skorsayısı=0;
        }
    }
}
