﻿using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class PlayerHand : MonoBehaviour
{
    [SerializeField] private CardDealer m_cardDlealer = null;
    [SerializeField] private List<RectTransform> m_playerCards = new List<RectTransform>();
    [SerializeField] private SpriteAtlas m_cardAtlas = null;

    private List<Card> m_playerHand = new List<Card>();

    


    // Start is called before the first frame update
    private void Start()
    {
        m_cardDlealer.CardDeal(m_playerHand);
        CardUpDate();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_cardDlealer.CardDeal(m_playerHand);
            CardUpDate();

            

            PokerFacilitator.ChangeCount--;
        }
    }
    private void CardUpDate()
    {
        for (int i = 0; i < m_playerHand.Count; i++)
        {
            var card = m_playerHand[i];
            m_playerCards[i].GetComponentInChildren<Image>().sprite = m_cardAtlas.GetSprite($"Card_{card.Num}");
            m_playerCards[i].GetComponentInChildren<TextMeshProUGUI>().text = $"{card.CardSuit}:{card.Number}";
        }
    }
    public void PlayercardDeal()
    {
        m_cardDlealer.CardDeal(m_playerHand);
        CardUpDate();
    }
}
