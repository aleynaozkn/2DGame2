using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YöneticiScript : MonoBehaviour
{
    public Text skor;
    public static float skorsayısı;
   

    
    void Update()
    {
       skor.text = skorsayısı.ToString(); 
    }
}
