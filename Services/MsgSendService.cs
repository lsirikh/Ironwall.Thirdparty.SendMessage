using Caliburn.Micro;
using Ironwall.Framework.Services;
using Ironwall.Thirdparty.SendMessage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ironwall.Thirdparty.SendMessage.Services
{
    public class MsgSendService
        : IService
    {
        
        #region - Ctors -
        public MsgSendService(MsgSendSetupModel setupModel)
        {
            _setupModel = setupModel;
        }
        #endregion
        #region - Implementation of Interface -
        public Task ExecuteAsync(CancellationToken token = default)
        {
            return Task.CompletedTask;
        }

        public void Stop()
        {
        }
        #endregion
        #region - Overrides -
        #endregion
        #region - Binding Methods -
        #endregion
        #region - Processes -

        public async Task<bool> SendMessage(IMsgModel msg)
        {
            UdpClient client = new UdpClient();
            byte[] datagram = Encoding.UTF8.GetBytes(msg.ToString());
            try
            {
                await client.SendAsync(datagram, datagram.Length, _setupModel.IpAddress, _setupModel.Port);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Raised Exception in SendMessage : {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SendMessage(IMsgModel msg, string ipAddress, int port)
        {
            UdpClient client = new UdpClient();
            byte[] datagram = Encoding.UTF8.GetBytes(msg.ToString());
            try
            {
                await client.SendAsync(datagram, datagram.Length, ipAddress, port);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Raised Exception in SendMessage : {ex.Message}");
                return false;
            }
        }
        #endregion
        #region - IHanldes -
        #endregion
        #region - Properties -
        #endregion
        #region - Attributes -
        private MsgSendSetupModel _setupModel;
        #endregion

    }
}
