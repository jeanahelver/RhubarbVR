﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RhubarbEngine.World.DataStructure;

namespace RhubarbEngine.World
{
    public interface IWorldObject
    {
        RefID ReferenceID { get; }

        World World { get; }

        IWorldObject Parent { get; }

        bool IsLocalObject { get; }

        bool IsPersistent { get; }

        bool IsRemoved { get; }
        DataNodeGroup serialize();

        void deSerialize(DataNodeGroup data,bool NewRefIDs = false, Dictionary<RefID, RefID> newRefID = default(Dictionary<RefID, RefID>));

    }
}
