using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variable : MonoBehaviour
{
    [SerializeField] Text _coinsetNam;
    public int coinSetNam = 10;
    private void Update()
    {
        _coinsetNam.text = "Coin:" + coinSetNam;
    }
}
