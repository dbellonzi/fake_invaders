using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour
{
    public int hitCount = 8;
    void OnCollisionEnter2D(Collision2D collision)
    {
        hitCount--;
        if(hitCount == 0)
        {
            Destroy(collision.collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
