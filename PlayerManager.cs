using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour
{
    //keeps track of current player and number of players and all their junk
    public Player[] players;
    private int numplayers;
    private Player currentPlayer;
    private int[] playerOrder; //should just have 0,1,2,3 or less depending on numplayers
    private int turn;

    public void setPlayers(Player[] pls) {
        players = pls;
        numplayers = pls.Length;
        currentPlayer = pls[0];
        turn = 0;
        playerOrder = new int[numplayers];
        for(int i = 0; i < numplayers; i++)
        {
            playerOrder[i] = i;
        }
    }
    public void shuffleOrder()
    {
        int n = numplayers;
        while (n > 1)
        {
            n--;
            System.Random rng = new System.Random();
            int k = rng.Next(n + 1);
            int val = playerOrder[k];
            playerOrder[k] = playerOrder[n];
            playerOrder[n] = val;

        }
        turn = 0;
    }
    public void nextPlayer()
    {
        turn++;
        if (turn == numplayers)
        {
            shuffleOrder();
        }
        int n = playerOrder[turn];
        currentPlayer = players[n];
    }
    public Player getCurrentPlayer()
    {
        return currentPlayer;
    }

    void Start() { 
        this.setPlayers(players);
        DontDestroyOnLoad(this.gameObject);

    }


}
