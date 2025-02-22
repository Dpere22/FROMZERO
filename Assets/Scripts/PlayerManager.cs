using UnityEngine;

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
        
    }

    public int GetHealth()
    {
        return health;
    }

    public void RemoveHealth(int hurt)
    {
        health -= hurt;
    }
}
