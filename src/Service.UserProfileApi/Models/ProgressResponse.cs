﻿using System.ComponentModel.DataAnnotations;
using Service.Core.Client.Constants;

namespace Service.UserProfileApi.Models
{
	public class ProgressResponse
	{
		[Range(1, 100)]
		public int TaskScore { get; set; }

		[Range(1, 9)]
		public int TutorialsPassed { get; set; }

		[Range(1, 270)]
		public int TasksPassed { get; set; }

		public int Days { get; set; }

		public StatusProgressModel Habit { get; set; }

		public StatusProgressModel Skill { get; set; }
		
		public StatusProgressModel Knowledge { get; set; }

		[EnumDataType(typeof(UserAchievement))]
		public UserAchievement[] Achievements { get; set; }
	}

	public class StatusProgressModel
	{
		[Range(1, 9)]
		public int Index { get; set; }

		public int Count { get; set; }

		[Range(1, 100)]
		public int Progress { get; set; }
	}
}