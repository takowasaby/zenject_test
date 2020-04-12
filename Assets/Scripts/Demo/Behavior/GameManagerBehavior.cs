using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManagerBehavior : MonoBehaviour
{
    private GameManager gameManager;

    [Inject]
    public void SetGameManager(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    private void Start()
    {
        this.gameManager.Initialize();
    }
}
