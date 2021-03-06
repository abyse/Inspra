﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{

    public PlayableDirector Director { get; set; }

    public void Pause()
    {
        if (!Director) return;
        Director.playableGraph.GetRootPlayable(0).SetSpeed(0);
        Director.GetComponent<PauseController>().Pause();
    }

    public void UnPause()
    {
        if (!Director) return;
        Director.GetComponent<PauseController>().UnPause();
        if (!(stopTimeline._firstTimeLineWasPaused || StopTimeline2._secondTimeLineWasPaused)) {
            Director.playableGraph.GetRootPlayable(0).SetSpeed(1);
        }
        
    }

}
