using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seller : MonoBehaviour
{
    [SerializeField] private GameObject _shopMenu;

    [SerializeField] private GameObject _dialog1;
    [SerializeField] private GameObject _dialog2;

    [SerializeField] private Button _button1;
    [SerializeField] private Button _button2;
    [SerializeField] private Button _button3;
    [SerializeField] private Button _button4;

    void Awake()
    {
        _shopMenu.SetActive(false);

        _dialog1.SetActive(true);
        _dialog2.SetActive(false);

        _button1.interactable = false;
        _button2.interactable = false;
        _button3.interactable = false;
        _button4.interactable = false;
    }

    void Update()
    {
        if (StoreManager.CoinNumber >= 200)
        {
            _button1.interactable = true;
            _button2.interactable = true;
        }
        else
        {
            _button1.interactable = false;
            _button2.interactable = false;
        }
        

        if (StoreManager.CoinNumber >= 100)
        {
            _button3.interactable = true;
            _button4.interactable = true;
        }
        else
        {
            _button3.interactable = false;
            _button4.interactable = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _shopMenu.SetActive(true);

            _dialog2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            _shopMenu.SetActive(false);

            _dialog2.SetActive(false);
        }
    }

    public void Spend100() 
    {
        StoreManager.CoinNumber -= 100;
    }

    public void Spend200()
    {
        StoreManager.CoinNumber -= 200;
    }

}