using System;
using System.Xml.Serialization;

namespace ArtZilla.MiniJikan.Core {
	[Serializable]
	public class LunchInfo {
		public static readonly TimeSpan DefaultStartTime = new TimeSpan(13, 0, 0);
		public static readonly TimeSpan DefaultDuration = new TimeSpan(0, 40, 0);

		[XmlAttribute]
		public DateTime FromDay { get; set; }

		[XmlIgnore]
		public TimeSpan StartTime { get; set; } = DefaultStartTime;

		[XmlAttribute]
		public double StartTimeSeconds {
			get { return StartTime.TotalSeconds; }
			set { StartTime = new TimeSpan(0, 0, (int) value); }
		}

		[XmlIgnore]
		public TimeSpan Duration { get; set; } = DefaultDuration;

		[XmlAttribute]
		public double DurationSeconds {
			get { return Duration.TotalSeconds; }
			set { Duration = new TimeSpan(0, 0, (int)value); }
		}

		[XmlIgnore]
		public TimeSpan EndTime => StartTime + Duration;
	}
}