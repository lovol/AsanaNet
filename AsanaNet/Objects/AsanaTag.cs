﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsanaNet
{
    public class AsanaTag : AsanaObject, IAsanaData
    {
        [AsanaDataAttribute     ("notes",       SerializationFlags.Optional)]
        public string           Notes           { get; set; }

        [AsanaDataAttribute     ("name",        SerializationFlags.Required)]
        public string           Name            { get; set; }

        [AsanaDataAttribute     ("created_at",  SerializationFlags.Omit)]
        public AsanaDateTime    CreatedAt       { get; private set; }

        [AsanaDataAttribute     ("followers",   SerializationFlags.Omit)]
        public AsanaUser[]      Followers       { get; private set; }

        [AsanaDataAttribute     ("workspace",   SerializationFlags.Required, "ID")]
        public AsanaWorkspace   Workspace       { get; private set; }

        // ------------------------------------------------------

        public bool IsObjectLocal { get { return ID == 0; } }

        public void Complete()
        {
            throw new NotImplementedException();
        }

        //
        internal AsanaTag()
        {
        }
    }
}
