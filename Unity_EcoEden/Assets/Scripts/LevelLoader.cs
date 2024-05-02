using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private Animator anim;
    public int SceneNum;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void LoadNextScene()
    {
        StartCoroutine(WaitASec());
    }

    public void ActuallyLoad()
    {
        if (SceneNum != 1) SoundManager.S.StopAmbience();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    private IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(2f);

        anim.SetTrigger("Start");
    }
}
