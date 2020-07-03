using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    private Cookie _cookie;

    private Text _text;
    void Awake()
    {
        _cookie.OnScoreChange += CookieOnOnScoreChange;
        _text = GetComponent<Text>();
    }

    private void CookieOnOnScoreChange(int score)
    {
        _text.text = $"Your Score is - {score}";
    }
}