using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Collect all the gold coins!");
    }

    // Update is called once per frame
    void Update()
    {
       if(FindObjectsOfType<Coin>().Length <1 && !done)
       {
            Debug.Log("You did it!");
            done = true;
            StartCoroutine(ResetCoroutine());
       }
    }

    IEnumerator ResetCoroutine()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Game");
    }

}
