using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateThis : MonoBehaviour {

    public GameObject cMain;

    public void Update()
    {
        if (WindowController.active_window == 1)
        {
            StartCoroutine(Deactivate());
        }
        else
        {
            cMain.SetActive(false);
        }
        
    }

    IEnumerator Deactivate()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(5);
        yield return waitForSeconds;
        cMain.SetActive(false);
    }
	
}
