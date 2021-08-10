using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statManager : MonoBehaviour
{
    public static float speed = 0.0f;
    public static float health = 0.0f;
    public static float attack = 0.0f;
    public static float attackRange = 0.0f;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        speed = 6.0f;
        health = 30.0f;
        attack = 3.0f;
        attackRange = 1.5f;
    }
}
