using Caliburn.Micro;
using Ironwall.Framework.ViewModels.ConductorViewModels;
using Ironwall.Libraries.Enums;
using Ironwall.Thirdparty.SendMessage.Models;
using Ironwall.Thirdparty.SendMessage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ironwall.Thirdparty.SendMessage.ViewModels
{
    public class MsgSetupViewModel : BaseViewModel
    {
        #region - Ctors -
        public MsgSetupViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            #region - Settings -
            Id = 156;
            Content = "";
            Category = CategoryEnum.PANEL_SHELL_VM_ITEM;
            #endregion - Settings -
            
        }

        #endregion
        #region - Implementation of Interface -
        #endregion
        #region - Overrides -
        protected override Task OnActivateAsync(CancellationToken cancellationToken)
        {
            ViewModelBinder.Bind(this, IoC.Get<MsgSetupView>(), null);
            _setupModel = IoC.Get<MsgSendSetupModel>();
            return base.OnActivateAsync(cancellationToken);
        }
        #endregion
        #region - Binding Methods -
        #endregion
        #region - Processes -
        #endregion
        #region - IHanldes -
        #endregion
        #region - Properties -

        public bool IsSendActive
        {
            get { return _setupModel.IsSendActive; }
            set 
            { 
                _setupModel.IsSendActive = value;
                NotifyOfPropertyChange(() => IsSendActive);
            }
        }


        public int First
        {
            get => int.Parse(_setupModel.IpAddress.Split('.')[0]);
            set 
            { 
                _first = value;
                _setupModel.IpAddress = $"{_first}.{Second}.{Third}.{Forth}";
                NotifyOfPropertyChange(() => First);
            }
        }

        public int Second
        {
            get => int.Parse(_setupModel.IpAddress.Split('.')[1]);
            set 
            { 
                _second = value;
                _setupModel.IpAddress = $"{First}.{_second}.{Third}.{Forth}";
                NotifyOfPropertyChange(() => Second);
            }
        }

        public int Third
        {
            get => int.Parse(_setupModel.IpAddress.Split('.')[2]);
            set 
            { 
                _third = value;
                _setupModel.IpAddress = $"{First}.{Second}.{_third}.{Forth}";
                NotifyOfPropertyChange(() => Third);
            }
        }

        public int Forth
        {
            get => int.Parse(_setupModel.IpAddress.Split('.')[3]);
            set 
            { 
                _forth = value;
                _setupModel.IpAddress = $"{First}.{Second}.{Third}.{_forth}";
                NotifyOfPropertyChange(() => Forth);
            }
        }

        public int Port
        {
            get { return _setupModel.Port; }
            set
            {
                _setupModel.Port = value;
                NotifyOfPropertyChange(() => Port);
            }
        }

        private MsgSendSetupModel _setupModel { get; set; }
        #endregion
        #region - Attributes -
        private int _first;
        private int _second;
        private int _third;
        private int _forth;
        #endregion
    }
}
