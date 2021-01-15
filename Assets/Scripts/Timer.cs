using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _time;
    private bool _timer = true;
    public UnityEvent TimeIsOver;

    void Update()
    {
        if (_timer)
        {
            _time -= Time.deltaTime;
            if (_time < 0)
            {
                _timer = false;
                TimeIsOver?.Invoke();                
            }
        }
    }
}
