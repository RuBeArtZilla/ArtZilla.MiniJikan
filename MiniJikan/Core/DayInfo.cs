using System;
using ArtZilla.MiniJikan.Core.Data;

namespace ArtZilla.MiniJikan.Core {
	public class DayInfo {
		public LunchInfo Lunch { get; set; } // Обеденный перерыв (не учитывается в общем итоге)

		public bool IsHoliday { get; set; } // Выходной или праздник

		public bool IsVacation { get; set; } // Отпуск (Ежегодный)

		public TimeSpan Duration { get; set; }

		public TimeSpan Counted { get; set; }

		
	}
}