using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Info : BasicScreen
{
    [SerializeField] private Button _profileButton;
    [SerializeField] private Button _homeButton;

    [SerializeField] private TMP_Text _coins;

    private void Start()
    {
        _profileButton.onClick.AddListener(ProfileButton);
        _homeButton.onClick.AddListener(HomeButton);

    }
    private void OnDestroy()
    {
        _profileButton.onClick.RemoveListener(ProfileButton);
        _homeButton.onClick.RemoveListener(HomeButton);

    }

    public override void ResetScreen()
    {
    }

    public override void SetScreen()
    {
        _coins.text = PlayerPrefs.GetInt("Coins").ToString();
    }

    private void ProfileButton()
    {
        UIManager.Instance.ShowScreen(ScreenTypes.Profile);
    }
    private void HomeButton()
    {
        UIManager.Instance.ShowScreen(ScreenTypes.Home);
    }

}
