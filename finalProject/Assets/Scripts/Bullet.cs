using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bullet Start");
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // hitInfo.SendMessage("TakeDamage", 10, SendMessageOptions.DontRequireReceiver);
        // Destroy(gameObject);
    }
}