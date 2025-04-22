using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variable : MonoBehaviour
{
    [SerializeField] Text _CoinText;
    public int coinSetNam = 10;
    private void Update()
    {
        _CoinText.text = "Coin:" + coinSetNam;
    }
}
