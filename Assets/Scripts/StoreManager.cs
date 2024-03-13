using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public static int CoinNumber;

    [SerializeField] TextMeshProUGUI _coinText;

    void Awake()
    {
        _coinText.text = "0";
        CoinNumber = 0;
    }

    void Update()
    {
        _coinText.text = CoinNumber.ToString();
    }
}
