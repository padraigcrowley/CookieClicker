using UnityEngine;
using UnityEngine.UI;

public class ParticleTrigger : MonoBehaviour
{
    [SerializeField] private Cookie _cookie;

    private ParticleSystem _child;

    void Awake()
    {
        _cookie.OnScoreChange += CookieOnOnScoreChange;
        _child = GetComponentInChildren<ParticleSystem>();
    }

    private void CookieOnOnScoreChange(int score)
    {
        if (score % 10 == 0)
        {
            _child.Emit(150);
        }
    }
}