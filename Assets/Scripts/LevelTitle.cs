using UnityEngine;
using System.Collections;

public class LevelTitle : MonoBehaviour
{
    [SerializeField] GameObject levelTextObject;
    [SerializeField] float blackScreenDuration = 0.5f;
    [SerializeField] float textScreenDuration = 0.5f;
    void Start()
    {
        StartCoroutine(LevelIntroRoutine());
    }

    IEnumerator LevelIntroRoutine()
    {
        Time.timeScale = 0f;

        levelTextObject.SetActive(false);

        yield return new WaitForSecondsRealtime(blackScreenDuration);

        levelTextObject.SetActive(true);

        yield return new WaitForSecondsRealtime(textScreenDuration);

        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
