using System;
using ArtZilla.MiniJikan.Core.Data;

namespace ArtZilla.MiniJikan.Core {
	public class DayInfo {
		public LunchInfo Lunch { get; set; } // ��������� ������� (�� ����������� � ����� �����)

		public bool IsHoliday { get; set; } // �������� ��� ��������

		public bool IsVacation { get; set; } // ������ (���������)

		public TimeSpan Duration { get; set; }

		public TimeSpan Counted { get; set; }

		
	}
}