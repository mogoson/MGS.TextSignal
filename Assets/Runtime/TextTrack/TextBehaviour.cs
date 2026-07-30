/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  TextBehaviour.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/23/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using TMPro;
using UnityEngine;
using UnityEngine.Playables;

namespace MGS.Timeline
{
    public class TextBehaviour : PlayableBehaviour
    {
        public string text;
        protected TextMeshProUGUI textMesh;
        protected Color textColor;

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            if (textMesh)
            {
                textMesh.text = string.Empty;
            }
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            textMesh = playerData as TextMeshProUGUI;
            if (textMesh)
            {
                textMesh.text = text;
                textColor = textMesh.color;
                textColor.a = info.weight;
                textMesh.color = textColor;
            }
        }
    }
}