using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Youwinmenu : MonoBehaviour
{
    public static Youwinmenu Instance;
    public GameObject container;
    public Button nextlevelbutton;

    private void OnEnable()
    {
        nextlevelbutton.onClick.AddListener(Handlenextlevelpressed);
    }

    private void OnDisable()
    {
        nextlevelbutton.onClick.RemoveListener(Handlenextlevelpressed);
    }

    private void Handlenextlevelpressed()
    {
        int nextsceneindex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextsceneindex);
    }
    private void Awake()
    {
        Instance = this;
    }

    public void Show()
    {
        container.SetActive(true);
    }
}
