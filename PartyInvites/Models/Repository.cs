namespace PartyInvites.Models
{
    public static class Repository
    {
        private static readonly List<GuestResponse> _guestResponses = new();

        public static IEnumerable<GuestResponse> GetRepository() => _guestResponses;

        public static void Add(GuestResponse guest) => _guestResponses.Add(guest);
    }
}