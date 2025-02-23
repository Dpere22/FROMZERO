using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private GameObject pauseMenu;
    private PlayerManager _playerManager;

    private InputAction _escapeAction;
    private bool _isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerManager = player.GetComponent<PlayerManager>();
        _escapeAction = InputSystem.actions.FindAction("Cancel");
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = $"Health: {_playerManager.GetHealth()}";
        if (_escapeAction.triggered)
        {
            TogglePauseMenu();
        }
    }

    private void TogglePauseMenu()
    {
        _isPaused = !_isPaused;
        pauseMenu.SetActive(_isPaused);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    
}
