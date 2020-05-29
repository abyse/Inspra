﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using System;

namespace ARQ.UIKit.TD
{       
    [Serializable]
    public class ButtonClickEvent : UnityEvent { }

    public class Button : MonoBehaviour
    {
        public ButtonClickEvent OnButtonClick;

        private PointerClickable _pointerClickable;
        private void Awake()
        {
            _pointerClickable = GetComponentInChildren<PointerClickable>();
            _pointerClickable.OnClick += OnClick;
        }

        private void OnClick()
        {
            Debug.Log("here");
            OnButtonClick.Invoke();
        }

        private void OnDestroy()
        {
            _pointerClickable.OnClick -= OnClick;
        }

        public void TestEvent()
        {
            print("pizda");
        }
    }
}
