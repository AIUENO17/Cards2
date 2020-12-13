using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class CPUHand : MonoBehaviour
{
    [SerializeField] private CardDealer m_cardDlealer = null;
    [SerializeField] private List<RectTransform> m_cpuCards = new List<RectTransform>();

    [SerializeField] private SpriteAtlas m_cardAtlas = null;
    private List<Card> m_cpuHand = new List<Card>();
    

    private void CardUpDate(bool judge = false)
    {
        for (int i = 0; i < m_cpuHand.Count;i++)
        {
            var card = m_cpuHand[i];
            if (judge)
            {
                m_cpuCards[i].GetComponentInChildren<Image>().sprite = m_cardAtlas.GetSprite($"Card_{card.Num}");
            }
            else
            {
                m_cpuCards[i].GetComponentInChildren<Image>().sprite = m_cardAtlas.GetSprite($"Card_54");
            }
            
        }
    }
    private void CPUCardDeal()
    {
        m_cardDlealer.CardDeal(m_cpuHand);
        CardUpDate();
    }

    public void CPUCardShowDown()
    {
        CardUpDate(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    private void CardUpDate()
    {
        for (int i = 0; i < m_cpuHand.Count; i++)
        {
            var card = m_cpuHand[i];
            m_cpuCards[i].GetComponentInChildren<Image>().sprite = m_cardAtlas.GetSprite($"Card_{card.Num}");
            m_cpuCards[i].GetComponentInChildren<TextMeshProUGUI>().text = $"{card.CardSuit}:{card.Number}";
        }
    }
}