﻿using BumpySellotape.Core.Input;
using BumpySellotape.Core.Transitions;
using BumpySellotape.Events.Model.Nodes;
using BumpySellotape.Events.View;
using UnityEngine;

namespace BumpySellotape.Events.Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private EventNode rootNode = default;
        [SerializeField] private CutsceneManager cutsceneManager = default;

        [field: SerializeField] public TransitionManager TransitionManager { get; private set; }
        [field: SerializeField] public ScreenManager ScreenManager { get; private set; }
        [field: SerializeField] public InputManager InputManager { get; private set; }
        public IEventManager EventManager { get; protected set; }

        public void Start()
        {
            if (EventManager == null)
                Debug.LogError("An event manager should be initialise on the GameController prior to start");
            LoadScreenWithEvent(rootNode);
        }

        private void LoadScreenWithEvent(EventNode node)
        {
            LoadScreen();
            if (node)
                EventManager.ProcessEventNode(node);
        }

        protected virtual void LoadScreen()
        { }

        protected virtual void StopScreen()
        { }

        protected virtual void ClearScreen()
        { }

        public void EnterCutscene(EventNode sceneEvent, GameObject sceneObject)
        {
            StopScreen();
            InputManager.SetInputHandler<CutsceneInputHandler, CutsceneManager>(cutsceneManager);// TECH DEBT - should clear input handler and set once loaded
            TransitionManager.DoTransition(
                null,
                () => StartScene(sceneEvent, sceneObject),
                ClearScreen);
        }

        public void ExitCutscene(EventNode gameEvent)
        {
            TransitionManager.DoTransition(
                null,
                () => LoadScreenWithEvent(gameEvent),
                cutsceneManager.UnloadCutscene);
        }

        private void StartScene(EventNode sceneEvent, GameObject sceneObject)
        {
            cutsceneManager.StartCutscene(sceneObject);
            EventManager.SetSystemLink(typeof(IEventTextManager), cutsceneManager.EventTextManager);
            EventManager.SetSystemLink(typeof(IBackgroundRenderer), cutsceneManager);
            EventManager.ProcessEventNode(sceneEvent);
        }

        private void Update()
        {/*
            if (Input.GetKeyDown(KeyCode.Space))
                EventManager.AdvanceFrame();
            */
        }
    }
}
