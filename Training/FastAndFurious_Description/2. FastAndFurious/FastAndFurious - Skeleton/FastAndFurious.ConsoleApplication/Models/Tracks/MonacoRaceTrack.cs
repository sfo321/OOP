namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    using Abstract;

    public class MonacoRaceTrack : RaceTrack
    {
        private const string MonacoRaceTrackName = "Monaco Race Track";
        private const int MonacoRaceTrackMaxParticipantsCount = 5;
        private const int MonacoRaceTrackMinParticipantsCount = 2;
        private const int MonacoRaceTrackTrackLengthInMeters = 2000;

        public MonacoRaceTrack() 
            : base(
                  MonacoRaceTrackName,
                  MonacoRaceTrackMaxParticipantsCount,
                  MonacoRaceTrackMinParticipantsCount,
                  MonacoRaceTrackTrackLengthInMeters)
        {
        }
    }
}
