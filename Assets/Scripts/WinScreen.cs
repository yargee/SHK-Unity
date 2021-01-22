using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.AllTargetsAreDead += OnAllEnemysDead;
    }

    private void OnDisable()
    {
        _player.AllTargetsAreDead -= OnAllEnemysDead;
    }

    public void OnAllEnemysDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
