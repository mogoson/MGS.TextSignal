/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  TextClip.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/23/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.Playables;

namespace MGS.Timeline
{
    [Serializable]
    public class TextClip : PlayableAsset
    {
        public string text;

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
        {
            var playable = ScriptPlayable<TextBehaviour>.Create(graph);
            playable.GetBehaviour().text = text;
            return playable;
        }
    }
}