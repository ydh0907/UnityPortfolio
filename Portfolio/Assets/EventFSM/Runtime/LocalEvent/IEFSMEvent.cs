namespace EFSM.Event
{

    public interface IEFSMEvent
    {
        public void Publish();
        public void Subscribe(IEFSMEventHandler handler);
        public void Unsubscribe(IEFSMEventHandler handler);
    }
}
