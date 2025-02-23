using UnityEngine;
using UnityEngine.UI;

public class DamageOverlay : MonoBehaviour
{
    [SerializeField] private Image overlay;
    [SerializeField] private float fadeDuration = 0.5f;

    private float _fadeTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        overlay.color = new Color(1f, 0f, 0f, 0f);
        Notify.DamageTaken += ShowDamageEffect;
    }

    void OnDestroy()
    {
        Notify.DamageTaken -= ShowDamageEffect;
    }

    private void ShowDamageEffect()
    {
        overlay.color = new Color(1f, 0f, 0f, 0.5f);
        _fadeTimer = fadeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        if (_fadeTimer > 0)
        {
            _fadeTimer -= Time.deltaTime;
            float alpha = _fadeTimer / fadeDuration * 0.5f;
            overlay.color = new Color(1, 0, 0, alpha);
        }
    }
}
