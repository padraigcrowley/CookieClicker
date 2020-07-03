using UnityEngine;

public class Cookie : MonoBehaviour
{
    public delegate void ScoreChange(int score);

    public event ScoreChange OnScoreChange;

    private Inputs _inputs;
    private int _score;

    void Awake()
    {
        _score = 0;
        _inputs = new Inputs();
        _inputs.Mouse.Interact.started += _ => OnCookieClick();
    }

    private void OnCookieClick()
    {
        _score++;
        if (null != OnScoreChange)
        {
            OnScoreChange(_score);
        }
    }

    private void OnEnable()
    {
        _inputs.Enable();
    }

    private void OnDisable()
    {
        _inputs.Disable();
    }
}