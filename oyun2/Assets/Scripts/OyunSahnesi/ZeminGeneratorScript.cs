﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGeneratorScript : MonoBehaviour
{
   public GameObject zemin;
   Transform tr;
   public int zeminsayısı;
   public float zemingenişlik;
   public float minimumy,maksimumy;
   private void Start(){
       tr=zemin.GetComponent<Transform>();
       Vector3 spawnkonumu = new Vector3();
       Vector2 yeniscale = new Vector2();
       for(int i=0;i<zeminsayısı; i++)
       {
           yeniscale.x = Random.Range(0.3f,0.8f);
           yeniscale.y = Random.Range(0.5f,0.6f);
           tr.localScale = yeniscale;

           spawnkonumu.y += Random.Range(minimumy,maksimumy);
           spawnkonumu.x = Random.Range(-zemingenişlik,zemingenişlik);

           Instantiate(zemin,spawnkonumu,Quaternion.identity);


       }

   }
}
