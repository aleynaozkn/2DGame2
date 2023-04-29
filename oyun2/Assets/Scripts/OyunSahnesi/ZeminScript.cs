using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminScript : MonoBehaviour
{
    public float ZıplamaKuvveti;
    public bool zeminetemasedildi;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = temas.collider.GetComponent<Rigidbody2D>();
            if(rb != null)
            {

                Vector2 zıplamaVelocity = rb.velocity;
                zıplamaVelocity.y = ZıplamaKuvveti;
                rb.velocity = zıplamaVelocity;

                if(zeminetemasedildi == false)
                {
                    YöneticiScript.skorsayısı++;
                    zeminetemasedildi = true;
                }
                anim.SetBool("TemasEdildi",true);
                Destroy(gameObject,1.3f);
            }

        }


    }
}
