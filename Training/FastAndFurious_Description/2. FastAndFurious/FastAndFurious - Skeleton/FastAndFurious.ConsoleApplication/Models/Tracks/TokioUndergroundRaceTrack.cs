namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    using Abstract;

    public class TokioUndergroundRaceTrack : RaceTrack
    {
        private const string TokioUndergroundRaceTrackName = "Tokio Underground Race Track";
        private const int TokioUndergroundRaceTrackMaxParticipantsCount = 8;
        private const int TokioUndergroundRaceTrackMinParticipantsCount = 2;
        private const int TokioUndergroundRaceTrackTrackLengthInMeters = 5000;

        public TokioUndergroundRaceTrack() 
            : base(
                  TokioUndergroundRaceTrackName,
                  TokioUndergroundRaceTrackMaxParticipantsCount,
                  TokioUndergroundRaceTrackMinParticipantsCount,
                  TokioUndergroundRaceTrackTrackLengthInMeters)
        {
        }
    }
}
