﻿using System;
using Lextm.SharpSnmpLib.Messaging;
using Lextm.SharpSnmpLib.Pipeline;

namespace Lextm.SharpSnmpLib.Browser
{
    internal class TrapV2MessageHandler : IMessageHandler
    {
        public ResponseData Handle(ISnmpMessage message, ObjectStore store)
        {
            throw new NotImplementedException();
        }
    }
}
