using TMPro;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    [SerializeField] private IntEventChannel _pointChannel;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int currentPoint;
    private void OnEnable()
    {
        currentPoint = 0;
        _text = GetComponent<TMP_Text>();
        _text.text = currentPoint.ToString();
        _pointChannel.OnEventRaised += IncreasePoint;
    }

    private void OnDisable()
    {
        _pointChannel.OnEventRaised -= IncreasePoint;
    }

    private void IncreasePoint(int pointValue)
    {
        currentPoint += pointValue;
        _text.text = currentPoint.ToString();
    }
}
