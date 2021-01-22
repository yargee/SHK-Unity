using UnityEngine;
using UnityEngine.Events;

public class HuntTimer : MonoBehaviour
{
    [SerializeField] private float _time;
    public event UnityAction HuntTimeIsOver;

    void Update()
    {
        _time -= Time.deltaTime;
        if (_time < 0)
        {
            HuntTimeIsOver?.Invoke();            
        }
    }
}
