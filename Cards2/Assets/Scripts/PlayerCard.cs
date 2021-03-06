﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCard : MonoBehaviour
{
    public CardDealer CardDealer;

    private List<Card> playerDeck = new List<Card>();

    public Card playerCard;

    public void SetPlayerDeck()
    {
        playerDeck = CardDealer.GetPlayerDeck();
    }

    public void SetPlayerCard()
    {
        playerCard = Deck.GetCard(playerDeck);
        Debug.Log(playerCard.Number);
    }
}
