using UnityEngine;
using UnityEngine.Events;

public class HuntTimer : MonoBehaviour
{
    [SerializeField] private float _time;

    public event UnityAction HuntTimeOver;

    private void Update()
    {
        _time -= Time.deltaTime;
        if (_time < 0 && _time > -1)
        {
            HuntTimeOver?.Invoke();
        }
    }
}
