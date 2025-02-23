using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI percentText;
    [FormerlySerializedAs("playerStart")] [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform gameEndLocation;
    private PlayerManager _playerManager;

    private InputAction _escapeAction;
    private bool _isPaused;

    private double _startY;
    private double _endY;
    private double _climbPercent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerManager = player.GetComponent<PlayerManager>();
        _escapeAction = InputSystem.actions.FindAction("Cancel");
        _startY = playerTransform.position.y;
        _endY = gameEndLocation.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = $"Health: {_playerManager.GetHealth()}";
        if (_escapeAction.triggered)
        {
            TogglePauseMenu();
        }
        CalculateClimbPercent();
    }

    private void TogglePauseMenu()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void CalculateClimbPercent()
    {
        _climbPercent = Math.Round((playerTransform.position.y - _startY) / (_endY - _startY), 2) * 100;
        percentText.text = $"Progress: {_climbPercent}%";
    }
    
    
}
