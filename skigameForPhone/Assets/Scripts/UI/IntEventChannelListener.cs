using UnityEngine;

public class IntEventChannelListener : MonoBehaviour
{
    [SerializeField] private int m_score;
    [SerializeField] private IntEventChannel _GameScoreChannel;
    [SerializeField] private StringEventChannel _UIGameScoreChannel;
    private void OnEnable()
    {
        m_score = 0;
        _GameScoreChannel.OnEventRaised += AddScore;
    }

    private void OnDisable()
    {
        _GameScoreChannel.OnEventRaised -= AddScore;
    }

    private void AddScore(int value)
    {
        m_score += value;
        _UIGameScoreChannel.RaiseEvent(m_score.ToString());
    }
}
