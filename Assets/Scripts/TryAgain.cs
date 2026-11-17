using UnityEngine;
using UnityEngine.SceneManagement;

    public class TryAgain : MonoBehaviour
    { 
    [SerializeField] private GameObject GameEnd;
    [SerializeField] private GameObject Death;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RestartGame();
        }
    }
    public void EndScreen()
    {
        GameEnd.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndScreen();
        }
    }
}
