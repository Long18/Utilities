using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingUI : MonoBehaviour
{
    [Header("Listening event")] [SerializeField]
    private BoolEventChannel onShowLoadingUI;

    [SerializeField] private FloatEventChannel onProgressChanged;

    [Header("Other")] [SerializeField] private Text progressText;
    [SerializeField] private GameObject gui;

    private void OnEnable()
    {
        onShowLoadingUI.OnEventRaised += OnShowLoadingUI;
        onProgressChanged.OnEventRaised += OnProgressChanged;
    }

    private void OnDisable()
    {
        onShowLoadingUI.OnEventRaised -= OnShowLoadingUI;
        onProgressChanged.OnEventRaised -= OnProgressChanged;
    }

    private void OnShowLoadingUI(bool isShow)
    {
        gui.SetActive(isShow);
    }

    private void OnProgressChanged(float progress)
    {
        var progressInt = (int) (progress * 100);
        progressText.text = $"{progressInt}%";
    }
}