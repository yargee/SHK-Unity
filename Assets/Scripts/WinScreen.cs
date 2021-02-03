using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private Hunt _hunt;

    private void OnEnable()
    {
        _hunt.AllTargetsDead += OnAllTargetsDead;
    }

    private void OnDisable()
    {
        _hunt.AllTargetsDead -= OnAllTargetsDead;
    }

    public void OnAllTargetsDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
