﻿using HeathenEngineering.Scriptable;
using HeathenEngineering.Serializable;
using UnityEngine;

namespace HeathenEngineering.Events
{
    [AddComponentMenu("System Core/Events/Color Change Event Listener")]
    public class ColorChangeEventListener : ChangeEventListener<SerializableColor>
    {
        public ColorVariable eventSource;

        public UnitySerializableColorChangeEvent valueChanged;
        public UnitySerializableColorDataEvent changed;

        public override DataVariable<SerializableColor> m_variable => eventSource;

        public override UnityChangeEvent<SerializableColor> m_changeresponce => valueChanged;

        public override GameEvent<SerializableColor> m_event => eventSource;

        public override UnityDataEvent<SerializableColor> m_responce => changed;
    }
}
