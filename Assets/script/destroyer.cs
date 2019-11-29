using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DestroyGameObject" || other.tag== "CoinCollect")
        {
            Destroy(other.gameObject);

        }
    }
}
