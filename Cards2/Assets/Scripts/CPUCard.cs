using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUCard : MonoBehaviour
{

    public CardDealer CardDealer;

    private List<Card> cpuDeck = new List<Card>();
    public Card cpuCard;

    public void SetCPUdeck()
    {
        cpuDeck = CardDealer.GetCPUDeck();
    }
    public  void SetCPUCard()
    {
        cpuCard = Deck.GetCard(cpuDeck);
        Debug.Log(cpuCard.Number);
    }
}

    
