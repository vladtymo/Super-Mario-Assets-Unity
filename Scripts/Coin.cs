using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gameObject.SetActive(false);
    }
}
