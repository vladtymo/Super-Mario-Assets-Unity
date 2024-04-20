using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public float speed = 1f; // швидкість руху героя

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        // left: -1
        // right: 1
        
        // переміщуємо героя, використовуючи швидкість [speed]
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;

        if (move < 0) sr.flipX = true;
        
        if (move > 0) sr.flipX = false;
    }
}
