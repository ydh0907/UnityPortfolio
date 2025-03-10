namespace EFSM.Event
{
    public interface IEFSMEventHandler
    {
        public void HandleEvent(IEFSMEvent evt);
    }
}
