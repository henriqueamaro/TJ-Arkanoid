using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    public BoxCollider2D collider;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        rigidbody.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }

}
