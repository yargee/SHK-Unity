using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private NpcCounter _counter;

    private void OnEnable()
    {
        _counter.AllNpcDead += OnAllTargetsDead;
    }

    private void OnDisable()
    {
        _counter.AllNpcDead -= OnAllTargetsDead;
    }

    public void OnAllTargetsDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
