using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSetiing : MonoBehaviour
{
    [SerializeField] GameObject _coin;
    private void Start()
    {
        Vector3 _raPos;
        for (int i = 0; i < Random.Range(15,25); i++)
        {
            _raPos = new Vector3(Random.Range(-2f, 2f), 0.8f, Random.Range(1.5f, 5.5f));
            Rigidbody rb = _coin.GetComponent<Rigidbody>();
            _coin.transform.position = _raPos;
            GameObject Coin =Instantiate(_coin);
        }
    }
}
