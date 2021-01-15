using UnityEngine;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;

    public void OnAllTargetsAreDead()
    {
        _winScreen.SetActive(true);
        Time.timeScale = 0;
    }    
}
