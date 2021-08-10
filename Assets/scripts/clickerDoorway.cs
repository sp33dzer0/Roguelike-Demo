using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickerDoorway : MonoBehaviour
{
    private GameObject _player;
    private GameObject _doorway;

    public void Awake()
    {
        _doorway = this.gameObject;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player detected");
            if (Input.GetKeyDown("w"))
            {
                sceneChanger.ToMines();
            }
        }
    }
}
