﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHelper 
{

    public const int CardMax = 52;


    /// <summary>
    /// 数字
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    /// // Start is called before the first frame update
    /// 

    public static int CardNumJudge(int num)
    {

        for(int i = 0; i < 13; i++)
        {
            if (num % 13 == i)
            {
                return i + 1;
                

            }
        }

        return 0;
    }


    public static Card.Suit CardSuitJudge(int num)
    {
        for(int i =0; i <(int)Card.Suit.Max; i++)
            if(num / 13 ==i)
            {
                return (Card.Suit)i;
            }

        return Card.Suit.Invalide;
 
        
    }
}
