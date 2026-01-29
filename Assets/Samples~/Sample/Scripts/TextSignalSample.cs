/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  TextSignalSample.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  03/23/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.TextSignal.Sample
{
    public class TextSignalSample : MonoBehaviour
    {
        public TextSignalReceiver receiver;
        public Text text;

        private void Awake()
        {
            receiver.OnSignalNotify += Receiver_OnSignalNotify;
        }

        private void Receiver_OnSignalNotify(string signal)
        {
            text.text = signal;
        }
    }
}