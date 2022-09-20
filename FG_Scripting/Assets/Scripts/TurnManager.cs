using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns;
    [SerializeField] public GameObject camera1;
    [SerializeField] public GameObject camera2;

    private int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }
    }

    private void Start()
    {
        camera1.SetActive(enabled);
        camera2.SetActive(!enabled);
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 0;
                waitingForNextTurn = false;
                ChangeTurn();
            }
        }
    }

    public bool IsItPlayerTurn(int index)
    {
        if (waitingForNextTurn)
        { 
            return false;
        }

        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
    }

    private void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
            camera2.SetActive(enabled);
            camera1.SetActive(!enabled);
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
            camera1.SetActive(enabled);
            camera2.SetActive(!enabled);
        }
    }
}
