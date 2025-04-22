using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sycophancy : MonoBehaviour
{
    [SerializeField] GameObject _getOn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.transform.SetParent(_getOn.transform);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.transform.SetParent(null);
        }
    }
}
