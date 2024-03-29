﻿namespace Project.Core.DTOs
{
	public class RecordDto : BaseDto
	{
		public string FullName { get; set; }
		public string RoomName { get; set; }
		public string IdentityNo { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime EntryDate { get; set; }
		public DateTime Depart { get; set; }
		public string RelativeNameSurname { get; set; }
		public string RelativePhone { get; set; }
		public string UniversityName { get; set; }
		public string Description { get; set; }
	}
}
