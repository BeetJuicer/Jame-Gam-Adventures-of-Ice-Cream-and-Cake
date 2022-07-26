using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float respawnTime;
    
    [SerializeField]
    private GameObject cam;

    [SerializeField]
    private RectTransform fader;

    [SerializeField]
    private GameObject gameOverMenu;

    private PlayerHandler playerHandler;

    private float respawnTimeStart;

    private bool respawn;

    private void Start()
    {
        playerHandler = player.GetComponent<PlayerHandler>();

        //Inward
        fader.gameObject.SetActive(true);
        AudioManager.instance.Play("Open");
     //   Invoke("ActivateCamera", 0.2f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            fader.gameObject.SetActive(false);
        });

    }

    void ActivateCamera()
    {
        cam.SetActive(true);
    }

    private void Update()
    {
        if (playerHandler.isDead && gameOverMenu.activeSelf)
        {
            if (PlayerInputHandler.GetInstance().SubmitInput)
            {
                Respawn();
                gameOverMenu.SetActive(false);
            }
        }
    }

    public void Respawn()
    {
        PauseMenu.gamePaused = true;
        //Outward
        fader.gameObject.SetActive(true);
        AudioManager.instance.Play("Close");
        LeanTween.scale(fader, Vector3.zero, 0);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            Invoke("LoadScene", 0.3f);
        });
        respawn = false;
    }

    private void LoadScene()
    {
       // cam.SetActive(false);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        PauseMenu.gamePaused = false;
    }
}
