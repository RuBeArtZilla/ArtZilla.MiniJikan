using System;
using System.Collections.Generic;

namespace ArtZilla.MiniJikan.Core {
	public class Day {
		public DateTime Date { get; }

		public TimeSpan Worked { get; set; }

		public TimeSpan Counted { get; set; }

		public List<WorkInfo> WorkList { get; set; }

		public bool IsWorkday { get; set; }

		public Day Transfer { get; set; }

		public LunchInfo Lunch { get; set; }
	}

	public class DayInfo {
		public LunchInfo Lunch { get; } // Обеденный перерыв (не учитывается в общем итоге)
		public bool IsHoliday { get; } // Выходной или праздник
		public bool IsVacation { get; } // Отпуск (Ежегодный)
	}

	public class MonthInfo {
		public bool IsClosed { get; }
	}

	public class YearInfo {
		public readonly Dictionary<ushort, MonthInfo> Months = new Dictionary<ushort, MonthInfo>();
		public bool IsClosed { get; }
	}
}