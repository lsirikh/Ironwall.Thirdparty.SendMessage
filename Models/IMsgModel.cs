namespace Ironwall.Thirdparty.SendMessage.Models
{
    public interface IMsgModel
    {
        public string Zone { get; set; }
        public int IdController { get; set; }
        public int IdSensor { get; set; }
        public string Camera1 { get; set; }
        public string Preset1 { get; set; }
        public string Camera2 { get; set; }
        public string Preset2 { get; set; }
        public string EventType { get; set; }
    }
}