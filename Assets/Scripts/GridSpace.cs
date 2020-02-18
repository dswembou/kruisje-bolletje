using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GridSpace : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Text buttonText;
    private GameController gameController;

    // gamecontroller wordt gevuld door de gamecontroller zelf
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    // Aangeroepen als op het vakje geklikt wordt
    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }
}