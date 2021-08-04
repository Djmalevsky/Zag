using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotCollision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
    }
}
