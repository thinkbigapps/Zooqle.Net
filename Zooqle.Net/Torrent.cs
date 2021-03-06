using System;

namespace Zooqle.Net
{
    public sealed class Torrent
    {
        internal Torrent() { }

        public override string ToString() => $@"Torrent ""{Title}""";

        /// <summary>
        /// Title of the torrent.
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// HEX/SHA1 value of the torrent metadata.
        /// </summary>
        public string InfoHash { get; internal set; }

        /// <summary>
        /// Total size of the torrent in bytes.
        /// </summary>
        public long Size { get; internal set; }

        /// <summary>
        /// Current count of seeders.
        /// </summary>
        public int SeedCount { get; internal set; }

        /// <summary>
        /// Current count of leechers.
        /// </summary>
        public int PeerCount { get; internal set; }

        /// <summary>
        /// The date and time on which the torrent was published in UTC.
        /// </summary>
        public DateTime PublishDate { get; internal set; }

        /// <summary>
        /// The URL for the torrent's page on Zooqle.
        /// </summary>
        public Uri PageUrl { get; internal set; }

        /// <summary>
        /// Direct download link for the torrent file.
        /// </summary>
        public Uri TorrentUrl { get; internal set; }

        /// <summary>
        /// Magnet URI for the torrent.
        /// </summary>
        public Uri MagnetUri { get; internal set; }
    }
}
