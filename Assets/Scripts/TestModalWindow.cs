﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class TestModalWindow : MonoBehaviour {
    protected ModalPanel modalPanel;
    protected DisplayManager displayManager;

    protected UnityAction myYesAction;
    protected UnityAction myNoAction;
    protected UnityAction myCancelAction;

    public void Awake () {
        
        myYesAction = new UnityAction (TestYesFunction);
        myNoAction = new UnityAction (TestNoFunction);
        myCancelAction = new UnityAction (TestCancelFunction);
    }
       
    public void TestYesFunction () {
        displayManager.DisplayMessage ("Hell yes, Brother!!");
    }

    public void TestNoFunction () {
        displayManager.DisplayMessage ("No can do!");
    }

    public void TestCancelFunction () {
        displayManager.DisplayMessage ("I surrender!?");
    }
}