﻿using common.server;
using common.server.model;

namespace client.realize.messengers.register
{

    /// <summary>
    /// 注册
    /// </summary>
    [MessengerIdRange((ushort)RegisterMessengerIds.Min, (ushort)RegisterMessengerIds.Max)]
    public sealed class RegisterMessenger : IMessenger
    {
        private readonly RegisterTransfer registerTransfer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registerTransfer"></param>
        public RegisterMessenger(RegisterTransfer registerTransfer)
        {
            this.registerTransfer = registerTransfer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        [MessengerId((ushort)RegisterMessengerIds.Offline)]
        public void Offline(IConnection connection)
        {
            registerTransfer.Exit();
        }

    }
}
