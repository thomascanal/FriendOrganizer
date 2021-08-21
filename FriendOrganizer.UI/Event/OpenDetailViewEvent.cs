using Prism.Events;

namespace FriendOrganizer.UI.Event
{
    public class OpenDetailViewEvent : PubSubEvent<OpenDetailViewEbentArgs>
    {
    }

    public class OpenDetailViewEbentArgs
    {
        public int? Id { get; set; }

        public string ViewModelName { get; set; }
    }
}
