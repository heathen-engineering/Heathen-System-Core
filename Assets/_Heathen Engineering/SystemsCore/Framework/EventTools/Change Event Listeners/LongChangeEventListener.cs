﻿using HeathenEngineering.Scriptable;
using UnityEngine;

namespace HeathenEngineering.Events
{
    [AddComponentMenu("System Core/Events/Long Change Event Listener")]
    public class LongChangeEventListener : ChangeEventListener<long>
    {
        public LongVariable eventSource;

        public UnityLongChangeEvent valueChanged;
        public UnityLongDataEvent changed;

        public override DataVariable<long> m_variable => eventSource;

        public override UnityChangeEvent<long> m_changeresponce => valueChanged;

        public override GameEvent<long> m_event => eventSource;

        public override UnityDataEvent<long> m_responce => changed;
    }
}
