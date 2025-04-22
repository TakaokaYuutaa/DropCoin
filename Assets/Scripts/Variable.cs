using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variable : MonoBehaviour
{
    [SerializeField] Text _CoinsetNam;
    public int coinSetNam = 10;
    private void Update()
    {
        _CoinsetNam.text = "Coin:" + coinSetNam;
    }
}
