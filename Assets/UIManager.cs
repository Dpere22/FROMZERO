using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI healthText;
    private PlayerManager _playerManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerManager = player.GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = _playerManager.GetHealth().ToString();
    }
}
