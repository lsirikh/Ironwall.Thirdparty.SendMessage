using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ironwall.Thirdparty.SendMessage.Models
{
    public class MsgSendSetupModel
    {
        #region - Ctors -
        #endregion
        #region - Implementation of Interface -
        #endregion
        #region - Overrides -
        #endregion
        #region - Binding Methods -
        #endregion
        #region - Processes -
        #endregion
        #region - IHanldes -
        #endregion
        #region - Properties -
        
        //public string GroupVca => Properties.Settings.Default.GroupVca;

        
        public bool IsSendActive
        {
            get => Properties.Settings.Default.IsSendActive;
            set
            {
                Properties.Settings.Default.IsSendActive = value;
                Properties.Settings.Default.Save();
            }
        }

        public string IpAddress
        {
            get => Properties.Settings.Default.IpAddress;
            set
            {
                Properties.Settings.Default.IpAddress = value;
                Properties.Settings.Default.Save();
            }
        }

        public int Port
        {
            get => Properties.Settings.Default.Port;
            set
            {
                Properties.Settings.Default.Port = value;
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        #region - Attributes -
        #endregion
    }
}
