using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyManager : MonoBehaviour
{
    public Text coinDisplay;
    
    public static double permanentIncome = 0.0f;
    public static double tempIncome = 0.0f;
    public static double baseTempIncome = 25.0f;
    public static double tempIncomeMultiplier = 0.0f;
    public double baseRevenue = 0.0f;
    public static double revenue = 0.0f;
    public double tickRate = 0.5f;
    public double t = 0.0f;
    private void Awake()
    {
    }
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        coinDisplay = GameObject.Find("coinDisplay").GetComponent<Text>();
    }
    void FixedUpdate()
    {
        revenueCalculator();
        //Debug.Log("revenue = " + revenue);
        t += Time.deltaTime;
        if(t > tickRate)
        {
            StartCoroutine("increaseIncome");
            t = 0;
        }
        coinDisplay.text = permanentIncome.ToString();
        if (sceneChanger.buildScene >= 3)
            inRunCurrency();
    }

    IEnumerator increaseIncome()
    {
        permanentIncome += (revenue / 10);
        yield return new WaitForSeconds(0.1f);
    }

    public void revenueCalculator()
    {
        revenue = (baseRevenue * 1) + 
            (clickerAdditives.miners * 1) + 
            (clickerAdditives.minecart *3);
    }

    public void inRunCurrency()
    {
        tempIncome = baseTempIncome * (1 + tempIncomeMultiplier);
    }
}
