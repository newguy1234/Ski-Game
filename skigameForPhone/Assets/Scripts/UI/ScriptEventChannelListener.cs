using UnityEngine;
using UnityEngine.Events;
public class ScriptEventChannelListener : MonoBehaviour
{
    [SerializeField] private StringEventChannel _UIGameScoreChannel;

    [SerializeField] private UnityEvent<string> m_response;
    private void OnEnable()
    {
        _UIGameScoreChannel.OnEventRaised += EventRaised;
    }
    private void OnDisable()
    {
        _UIGameScoreChannel.OnEventRaised -= EventRaised;
    }

    private void EventRaised(string passstring)
    {
        m_response.Invoke(passstring);
    }
}
