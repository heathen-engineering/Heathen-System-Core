﻿using HeathenEngineering.Scriptable;
using UnityEngine;

namespace HeathenEngineering.Events
{
    [AddComponentMenu("System Core/Events/Float Change Event Listener")]
    public class FloatChangeEventListener : ChangeEventListener<float>
    {
        public FloatVariable eventSource;

        public UnityFloatChangeEvent valueChanged;
        public UnityFloatDataEvent changed;

        public override DataVariable<float> m_variable => eventSource;

        public override UnityChangeEvent<float> m_changeresponce => valueChanged;

        public override GameEvent<float> m_event => eventSource;

        public override UnityDataEvent<float> m_responce => changed;
    }
}
