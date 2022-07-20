using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ironwall.Thirdparty.SendMessage.Models
{
    public class MsgModel : IMsgModel
    {
        #region - Ctors -
        public MsgModel()
        {

        }
        public MsgModel(string zone, int idController, int idSensor, string camera1, string preset1, string camera2, string preset2, string eventType = "Intrusion")
        {
            Zone = zone;
            IdController = idController;
            IdSensor = idSensor;
            Camera1 = camera1;
            Camera2 = camera2;
            Preset1 = preset1;
            Preset2 = preset2;
            EventType = eventType;
        }
        #endregion
        #region - Implementation of Interface -
        #endregion
        #region - Overrides -
        public override string ToString()
        {
            ///Ex) EventType : Intrusion, Zone : 23, IdControl : 1, IdSensor : 91, CameraName : CF-003, PresetNo : 2
            return $"EventType : {EventType}, Zone : {Zone}, IdControl : {IdController}, IdSensor : {IdSensor}, Camera1 : {Camera1}, Preset1 : {Preset1}, Camera2: { Camera2}, Preset2: { Preset2}";
        }
        #endregion
        #region - Binding Methods -
        #endregion
        #region - Processes -
        #endregion
        #region - IHanldes -
        #endregion
        #region - Properties -
        public string Zone { get; set; }
        public int IdController { get; set; }
        public int IdSensor { get; set; }
        public string Camera1 { get; set; }
        public string Camera2 { get; set; }
        public string Preset1 { get; set; }
        public string Preset2 { get; set; }
        /// <summary>
        /// EventType Properties
        /// Intrusion
        /// </summary>
        public string EventType { get; set; }
        #endregion
        #region - Attributes -
        #endregion

    }
}
