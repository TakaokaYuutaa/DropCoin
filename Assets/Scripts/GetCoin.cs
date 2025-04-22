using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    public Variable _vari;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            _vari.coinSetNam += 1;
           Destroy(collision.gameObject);
        }
    }
}
