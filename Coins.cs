using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().CollectCoins();
        Destroy(gameObject);
    }
}