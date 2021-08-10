using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickerAdditives : MonoBehaviour
{
    public static int miners = 1;
    public static int minerCost = 10;
    public static int minecart = 0;
    public static int minecartCost = 75;

    public Text minersText;
    public Text minercartText;
    public Text healthText;
    public Text speedText;
    public Text attackText;
    public Text attackRangeText;

    public static float health = 35f;
    public static float healthCost = 35f;
    public static float speed = 6f;
    public static float speedCost = 40f;
    public static float attack = 3f;
    public static float attackCost = 60f;
    public static float attackRange = 1.5f;
    public static float attackRangeCost = 60f;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void moneyNow()
    {
        moneyManager.permanentIncome += moneyManager.revenue / 10;
        Debug.Log("Added " + (moneyManager.revenue / 10) + " income to your total");
    }

    public void addMiner()
    {
        if (moneyManager.permanentIncome >= minerCost)
        {
            moneyManager.permanentIncome -= minerCost;
            miners++;
            minerCost = minerCost + 10;
            minersText.text = "Miners Cost: " + minerCost + "G | Miners employed: " + miners;
            Debug.Log("miner button press successful");
        }
    }
    
    public void addMinecart()
    {
        if (moneyManager.permanentIncome >= minecartCost)
        {
            moneyManager.permanentIncome -= minecartCost;
            minecart++;
            minecartCost = minecartCost +50;
            minercartText.text = "Minercart Cost: " + minecartCost + "G | Minecarts owned: " + minecart;
            Debug.Log("minecart button press successful");
        }
    }

    public void playGame()
    {
        sceneChanger.ToCampsite();
    }

    public void buyHealth()
    {
        if (moneyManager.permanentIncome >= healthCost)
        {
            moneyManager.permanentIncome -= healthCost;
            health += 10f;
            healthCost = healthCost + 35;
            healthText.text = "Buy Health Upgrade: " + healthCost + "g";
            Debug.Log("Buy Health button press successful. Health now " + health);
        }
    }
    public void buySpeed()
    {
        if (moneyManager.permanentIncome >= speedCost)
        {
            moneyManager.permanentIncome -= speedCost;
            speed++;
            speedCost = speedCost + 40;
            speedText.text = "Buy Speed Upgrade: " + speedCost + "g";
            Debug.Log("Buy Speed button press successful. Speed now " + speed);
        }
    }
    public void buyAttack()
    {
        if (moneyManager.permanentIncome >= attackCost)
        {
            moneyManager.permanentIncome -= attackCost;
            attack++;
            attackCost = attackCost + 60;
            attackText.text = "Buy Attack Upgrade: " + attackCost + "g";
            Debug.Log("Buy Attack button press successful. Attack now" + attack);
        }
    }
    public void buyAttackRange()
    {
        if (moneyManager.permanentIncome >= attackRangeCost)
        {
            moneyManager.permanentIncome -= attackRangeCost;
            attackRange += 0.1f;
            attackRangeCost = attackRangeCost + 60;
            attackRangeText.text = "Buy Attack Range Upgrade: " + attackRangeCost + "g";
            Debug.Log("Buy Attack Range button press successful. Attack range now " + attackRange);
        }
    }
    public void exitShop()
    {
        shopKeeper.shopOpen = false;
    }

    public void toSettings()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
