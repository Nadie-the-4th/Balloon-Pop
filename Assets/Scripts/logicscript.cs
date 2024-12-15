using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logicscript : MonoBehaviour
{
public GameObject Canvas;
void Start()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void restartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void gameOver()
{
    Canvas.SetActive(true);
     print(gameObject.name + " tag works!! : ");
    Canvas.SetActive(true);
    print("Game over :3");
}


}
