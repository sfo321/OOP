namespace FastAndFurious.ConsoleApplication.Models.Tracks
{
    using Abstract;

    public class StormblazeRaceTrack : RaceTrack
    {
        private const string StormblazeRaceTrackName = "Stormblaze Race Track";
        private const int StormblazeRaceTrackMaxParticipantsCount = 4;
        private const int StormblazeRaceTrackMinParticipantsCount = 2;
        private const int StormblazeRaceTrackLengthInMeters = 1000;

        public StormblazeRaceTrack() 
            : base(
                  StormblazeRaceTrackName,
                  StormblazeRaceTrackMaxParticipantsCount,
                  StormblazeRaceTrackMinParticipantsCount,
                  StormblazeRaceTrackLengthInMeters)
        {
        }
    }
}
