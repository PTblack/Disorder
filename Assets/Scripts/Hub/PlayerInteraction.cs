using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    bool nearInteractable;
    string sceneToChangeTo;

    private void Update()
    {
        ManageInteraction();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearInteractable = true;
        Debug.Log(nearInteractable);
        sceneToChangeTo = collision.GetComponent<LevelChange>().LevelToChangeTo;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        nearInteractable = false;
        Debug.Log(nearInteractable);
    }

    private void ManageInteraction()
    {
        if(Input.GetKey(KeyCode.X))
        {
            if(nearInteractable)
                SceneManager.LoadScene(sceneToChangeTo);
        }
    }
}
