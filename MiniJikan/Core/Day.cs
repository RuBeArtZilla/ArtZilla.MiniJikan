using System;

namespace ArtZilla.MiniJikan.Core {
	public class Day {
		public DateTime Date { get; }

		public TimeSpan Worked { get; set; }

		public TimeSpan Counted { get; set; }

		public bool IsWorkday { get; set; }

		public Day Transfer { get; set; }

		public Lunch Lunch { get; set; }
	}

	public class Lunch {
		public TimeSpan Duration { get; set; }

		public TimeSpan StartTime { get; set; }

		public TimeSpan EndTime { get; set; }
	}
}