using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private float checkPointPositioX;
    private float checkPointPositioY;

    public Animator animator;


    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositioX") != 0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("checkPointPositioX"), PlayerPrefs.GetFloat("checkPointPositioY"));
        }
    }


    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositioX", x);
        PlayerPrefs.SetFloat("checkPointPositioY", y);
    }

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
