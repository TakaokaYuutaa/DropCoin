using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSetiing : MonoBehaviour
{
    [SerializeField] GameObject _coin;
    public Variable Vari;
    private void Start()
    {
        for (int i = 0; i < Random.Range(15, 20); i++)
        {
            CoinSet();
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Vari.coinSetNam > 0)
            {
                CoinSet();
                Vari.coinSetNam -= 1;
            }
        }
    }
    void CoinSet()
    {
        Vector3 _raPos;
        _raPos = new Vector3(Random.Range(-2f, 2f), 2f, Random.Range(1.5f, 5.5f));
        Rigidbody rb = _coin.GetComponent<Rigidbody>();
        _coin.transform.position = _raPos;
        GameObject Coin = Instantiate(_coin);
    }
}
