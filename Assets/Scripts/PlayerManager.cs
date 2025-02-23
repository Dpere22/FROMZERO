using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int health = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public void RemoveHealth(int hurt)
    {
        health -= hurt;
    }

    public void AddHealth(int heal)
    {
        health += heal;
    }
}
