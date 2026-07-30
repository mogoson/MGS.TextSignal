/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  TextTrack.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/23/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using TMPro;
using UnityEngine.Timeline;

namespace MGS.Timeline
{
    [TrackColor(0, 1, 1)]
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TextClip))]
    public class TextTrack : PlayableTrack { }
}