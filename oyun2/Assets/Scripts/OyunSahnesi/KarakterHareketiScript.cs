using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketiScript : MonoBehaviour
{
   public float harekethızı;
   private float yatayhareket;
   Rigidbody2D rb;
   private void Start(){
       rb=GetComponent<Rigidbody2D>();
   }
   private void Update()
   {
       yatayhareket = Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(yatayhareket*harekethızı*Time.deltaTime,rb.velocity.y);
       Vector2 yeniscale = transform.localScale;

       if(yatayhareket > 0)
       {
           yeniscale.x=0.65f;
       }
       if(yatayhareket < 0)
       {
           yeniscale.x=-0.65f;
       }
       transform.localScale = yeniscale;

       
    

   }
   
   
}
