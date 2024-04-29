using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void LoadNextScene()
    {
        anim.SetTrigger("Start");

        StartCoroutine(WaitASec());
    }

    private IEnumerator WaitASec()
    {
        yield return new WaitForSeconds(2f);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
