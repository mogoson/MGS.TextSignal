[TOC]

# MGS.Timeline

## Summary

- Emitter and Receiver for text signal with Unity Timeline.

## Ability

- Add signal emitter to send text signal in timeline Singal Track.
- Notify event on receive signal.

- Add Text Track to Unity Timeline and play text clip.

## Install

- Unity --> Window --> Package Manager --> "+" --> Add package from git URL...

  ```text
  https://github.com/mogoson/MGS.Timeline.git?path=/Assets
  ```

## Usage

### Text Signal

1. Open the Timeline editor and create timeline asset.
2. "Add Text Signal Emitter" from context menu on Signal Track.
3. Select the emitter and set the "Signal" field.
4. Add TextSignalReceiver component to the gameobject that with SignalReceiver component.
5. Register event to TextSignalReceiver component.

### Text Track

1. Open the Timeline editor and create timeline asset.
2. Click the "+" button and select the "Text Track" to add a text track.
3. Set a TextMeshProUGUI to the track binding object field.
4. Click context menu "Add Text Clip" to add a text clip to track.
5. Select clip and set the "Text" field. 

## Samples

- Unity --> Window --> Package Manager --> Packages-Mogoson --> Timeline --> Samples.

---

Copyright © 2026 Mogoson.	mogoson@outlook.com