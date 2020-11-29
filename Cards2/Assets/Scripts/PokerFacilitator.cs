using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerFacilitator : MonoBehaviour
{
    [SerializeField] private PlayerHand m_playerHand;
    [SerializeField] private CPUHand m_cpuHand;

    public static int ChangeCount = 1;

    private enum GameState
    {
        Invalid = -1,
        Init,
        Deal,
        Change,
        Judge,
        Result
    }

    private GameState m_gameState = GameState.Invalid;
    

    
    void Update()
    {
        
    }
}
