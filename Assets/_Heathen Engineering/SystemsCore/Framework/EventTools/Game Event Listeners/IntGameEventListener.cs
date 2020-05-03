﻿using UnityEngine;

namespace HeathenEngineering.Events
{
    [AddComponentMenu("System Core/Events/Int Game Event Listener")]
    public class IntGameEventListener : GameEventListener<int>
    {
        public IntGameEvent Event;
        public UnityIntDataEvent Responce;

        public override GameEvent<int> m_event => Event;

        public override UnityDataEvent<int> m_responce => Responce;
    }
}
