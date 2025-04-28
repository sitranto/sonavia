using sonavia.Models;

namespace sonavia
{
    public static class TrackManager
    {
        private static string[]? trackPaths;
        public static readonly List<Track> tracks = [];
        public static readonly List<Album> albums = [];
        public static readonly List<Artist> artists = [];

        public static void GetMusicData()
        {
            trackPaths = FileManager.GetAllTracks();
            LoadData(trackPaths);
        }

        private static void LoadData(string[] trackPaths)
        {
            GetAlbumsAndArtistsNames(trackPaths);

            foreach (var file in trackPaths)
            {
                var trackMetadata = FileManager.GetTrackMetaData(file);
                var metadataAlbum = trackMetadata?.Album ?? "Неизвестен";
                var metadataArtist = string.Join(", ", trackMetadata?.Performers ?? ["Неизвестен"]);
                var metadataTitle = trackMetadata?.Title ?? "Поврежден";

                if (metadataArtist == "") metadataArtist = "Неизвестен";

                var track = new Track(metadataTitle, file);
                var album = albums.Find(name => metadataAlbum.Equals(name.name));
                var artist = artists.Find(name => metadataArtist.Equals(name.name));

                track.album = album;
                track.artist = artist;
                track.durationInSeconds = trackMetadata?.Length ?? "-";

                album!.tracks.Add(track);
                album.artist = artist;

                artist!.albums.Add(album);
                artist.tracks.Add(track);

                tracks.Add(track);
            }
        }

        private static void GetAlbumsAndArtistsNames(string[] paths)
        {
            var albumNames = new List<string>();
            var artistNames = new List<string>();

            foreach (var file in paths)
            {
                var albumName = FileManager.GetTrackMetaData(file)?.Album;

                albumName ??= "Неизвестен";
                if (albumNames.Contains(albumName)) continue;

                albumNames.Add(albumName);
            }

            foreach (var file in paths)
            {
                var artistName = string.Join(", ", FileManager.GetTrackMetaData(file)?.Performers ?? ["Неизвестен"]);

                if (artistName == "") artistName = "Неизвестен";                
                if (artistNames.Contains(artistName)) continue;

                artistNames.Add(artistName);
            }

            foreach (var artist in artistNames)
            {
                artists.Add(new Artist(artist));
            }

            foreach (var album in albumNames)
            {
                albums.Add(new Album(album));
            }
        }
    }
}
