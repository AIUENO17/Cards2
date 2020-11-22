using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
    //List<型名> 変数名　= new List<型名>();
    private List<Card> deck = new List<Card>();
    //List
    private List<Card> playerHand = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {

        deck = Deck.ShuffleDeck(Deck.GetDeck());

    }

    // Update is called once per frame
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }
    }
}
