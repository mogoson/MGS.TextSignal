/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  TextSignalReceiver.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson.
 *  Version      :  1.0.0
 *  Date         :  03/23/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.Playables;

namespace MGS.TextSignal
{
    public class TextSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public event Action<string> OnSignalNotify;

        public void OnNotify(Playable origin, INotification notification, object context)
        {
            var signal = string.Empty;
            if (notification is TextSignalEmitter emitter)
            {
                signal = emitter.signal;
            }
            OnSignalNotify?.Invoke(signal);
        }
    }
}