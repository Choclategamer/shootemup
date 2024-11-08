using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class shopMaster : MonoBehaviour
{
    GameMaster gm;
    EnemyMovement em;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    int randomMoney;





    private void Awake()
    {
        gm = GetComponent<GameMaster>();
        em = GetComponent<EnemyMovement>();
        
        
       
    }
    
    void Start()
    {
      
    }

   
    void Update()
    {
        //button 1/////
        if (gm.money >= 100)
        {
            Button1.SetActive(true);
        }
        else
        {
            Button1.SetActive(false);
        }
        //button1//////


        //button 2/////
        if (gm.money >= 200)
        {
            Button2.SetActive(true);
        }
        else
        {
            Button2.SetActive(false);
        }
        //button2//////


        //button 3/////
        if (gm.money >= 300)
        {
            Button3.SetActive(true);
        }
        else
        {
            Button3.SetActive(false);
        }
        //button3//////
        //button 4/////
        if (gm.money >= 400)
        {
            Button4.SetActive(true);
        }
        else
        {
            Button4.SetActive(false);
        }
        //button4//////

        //if (em.hp <= 0)
        //{
        //  randomMoney = Random.Range(10, 21);
        //gm.money = gm.money + randomMoney;
        //}




    }

    public void MoneyRemove1()
    {
        gm.money = gm.money - 100;
        
    }
    public void MoneyRemove2()
    {
        gm.money = gm.money - 200;
        
    }
    public void MoneyRemove3()
    {
        gm.money = gm.money - 300;
        
    }
    public void MoneyRemove4()
    {
        gm.money = gm.money - 400;

    }
}


    
    


