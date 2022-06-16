namespace UniteScripts
{

    public enum MessageSenderType
    {
        NONE,
        DEAD,
        DAMAGED,
    }

    public interface IMessageReceiver
    {
        void OnReceiveMessage(MessageSenderType type, object sender, object msg);
    }
}