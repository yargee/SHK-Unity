using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private NpcCounter _counter;

    private void OnEnable()
    {
        _counter.AllNpcDead += OnAllNpcDead;
    }

    private void OnDisable()
    {
        _counter.AllNpcDead -= OnAllNpcDead;
    }

    public void OnAllNpcDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
