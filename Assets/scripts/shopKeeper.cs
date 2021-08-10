using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopKeeper : MonoBehaviour
{
    private GameObject _player;
    private GameObject _shop;
    public static bool shopOpen = false;

    public void Awake()
    {
        _shop = this.gameObject;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player detected");
            if (Input.GetKeyDown("w"))
            {
                shopOpen = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            shopOpen = false;
        }
    }
}
