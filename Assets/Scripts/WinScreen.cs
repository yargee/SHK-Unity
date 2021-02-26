using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private EnemyCounter _counter;

    private void OnEnable()
    {
        _counter.AllTargetsDead += OnAllTargetsDead;
    }

    private void OnDisable()
    {
        _counter.AllTargetsDead -= OnAllTargetsDead;
    }

    public void OnAllTargetsDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
