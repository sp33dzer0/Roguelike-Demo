using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            moneyManager.tempIncome += (moneyManager.baseTempIncome * (1 + moneyManager.tempIncomeMultiplier));
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 2.0f, 0);
    }
}
