using System;
using System.Xml.Serialization;

namespace ArtZilla.MiniJikan.Core {
	[Serializable]
	public class CompanyInfo {
		[XmlAttribute]
		public string Name {
			get { return _name; }
			set {
				if (string.IsNullOrEmpty(value)) {
					_name = string.Empty;
					NameSpecified = false;
				} else {
					_name = value;
					NameSpecified = true;
				}
			}
		}

		[XmlIgnore]
		public bool NameSpecified { get; set; }

		[XmlAttribute]
		public DateTime Start {
			get { return _start; }
			set {
				_start = value;
				StartSpecified = value != DateTime.MinValue;
			}
		}

		[XmlIgnore]
		public bool StartSpecified { get; set; }

		[XmlAttribute]
		public DateTime Quit {
			get { return _quit; }
			set {
				_quit = value;
				QuitSpecified = value != DateTime.MinValue;
			}
		}

		[XmlIgnore]
		public bool QuitSpecified { get; set; }

		private string _name = string.Empty;
		private DateTime _quit = DateTime.MinValue;
		private DateTime _start = DateTime.MinValue;
	}
}