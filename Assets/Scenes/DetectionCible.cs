using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionCible : MonoBehaviour
{
    [SerializeField] private float delayTime = 4f;
    private float timeElapsed = 0f;
    private bool startTimer = false;

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Cible"))
        {
            startTimer = true; 
        }
    }

    void Update()
    {
        if (startTimer)
        {
            timeElapsed += Time.deltaTime;
            Debug.Log(timeElapsed);

            if (timeElapsed > delayTime)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}