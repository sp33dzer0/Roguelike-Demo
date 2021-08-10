using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiScript : MonoBehaviour
{
    public GameObject coinDisplay;

    //Main Menu UI
    public GameObject titleButton;
    public GameObject playGame;
    public GameObject settings;
    
    //Mines UI
    public GameObject moneyNow;
    public GameObject buyMiners;
    public GameObject buyMinecarts;
    public GameObject returnToCamp;
    public GameObject evaluators;

    //In-run UI
    public GameObject inRunCoinDisplay;

    //ShopUI
    public GameObject shopKeeperOutline;
    public GameObject buyAttack;
    public GameObject buySpeed;
    public GameObject buyHealth;
    public GameObject buyAttackRange;
    public GameObject exitShop;

    //public GameObject healthBar;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Start()
    {
    }

    public void Update()
    {
        ButtonToggle();
    }

    public void ButtonToggle()
    {
        if(sceneChanger.buildScene == 0)
        {
            //Main Menu UI
            titleButton.SetActive(true);
            playGame.SetActive(true);
            settings.SetActive(true);

            coinDisplay.SetActive(false);

            //Mines UI
            moneyNow.SetActive(false);
            buyMiners.SetActive(false);
            buyMinecarts.SetActive(false);
            returnToCamp.SetActive(false);
            evaluators.SetActive(false);

            //In Run UI
            inRunCoinDisplay.SetActive(false);

            //Shop UI
            shopKeeperOutline.SetActive(shopKeeper.shopOpen);
        }
        if(sceneChanger.buildScene == 1)
        {
            //Main Menu UI
            titleButton.SetActive(false);
            playGame.SetActive(false);
            settings.SetActive(false);

            coinDisplay.SetActive(true);

            //Mines UI
            moneyNow.SetActive(false);
            buyMiners.SetActive(false);
            buyMinecarts.SetActive(false);
            returnToCamp.SetActive(false);
            evaluators.SetActive(false);

            //In Run UI
            inRunCoinDisplay.SetActive(false);

            //Shop UI
            shopKeeperOutline.SetActive(shopKeeper.shopOpen);
        }
        if(sceneChanger.buildScene == 2)
        {
            //Main Menu UI
            titleButton.SetActive(false);
            playGame.SetActive(false);
            settings.SetActive(false);

            coinDisplay.SetActive(true);

            //Mines UI
            moneyNow.SetActive(true);
            buyMiners.SetActive(true);
            buyMinecarts.SetActive(true);
            returnToCamp.SetActive(true);
            evaluators.SetActive(true);

            //In Run UI
            inRunCoinDisplay.SetActive(false);

            //Shop UI
            shopKeeperOutline.SetActive(shopKeeper.shopOpen);
        }
        if (sceneChanger.buildScene == 3)
        {
            //Main Menu UI
            titleButton.SetActive(false);
            playGame.SetActive(false);
            settings.SetActive(false);

            coinDisplay.SetActive(true);

            //Mines UI
            moneyNow.SetActive(false);
            buyMiners.SetActive(false);
            buyMinecarts.SetActive(false);
            returnToCamp.SetActive(false);
            evaluators.SetActive(false);

            //In Run UI
            inRunCoinDisplay.SetActive(true);

            //Shop UI
            shopKeeperOutline.SetActive(shopKeeper.shopOpen);
        }

    }
}
