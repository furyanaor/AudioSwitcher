﻿using System;

namespace AudioSwitcher.AudioApi.Sandbox
{
    public class SandboxDevice : Device
    {
        public DeviceType type;
        public string interfaceName;
        public DeviceIcon icon;
        public Guid id;
        public bool isMuted;
        public string name;
        public DeviceState state;
        public string fullName;

        public SandboxDevice(IDeviceEnumerator enumerator)
            : base(enumerator)
        {
        }

        public override Guid Id
        {
            get { return id; }
        }

        public override string InterfaceName
        {
            get { return interfaceName; }
        }

        public override string Name
        {
            get { return name; }
            set { }
        }

        public override string FullName
        {
            get { return fullName; }
        }

        public override DeviceIcon Icon
        {
            get { return icon; }
        }

        public override DeviceState State
        {
            get { return state; }
        }

        public override DeviceType DeviceType
        {
            get { return type; }
        }

        public override bool IsMuted
        {
            get { return isMuted; }
        }

        public override int Volume { get; set; }

        public override bool Mute()
        {
            return isMuted = true;
        }

        public override bool UnMute()
        {
            return isMuted = false;
        }

        public override event AudioDeviceChangedHandler VolumeChanged;
    }
}