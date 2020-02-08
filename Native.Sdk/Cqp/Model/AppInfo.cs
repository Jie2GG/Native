﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Sdk.Cqp.Model
{
	/// <summary>
	/// 表示当前插件的一些基本信息的类
	/// </summary>
	public class AppInfo
	{
		/// <summary>
		/// 获取当前应用的 AppID
		/// </summary>
		public static string Id { get; private set; }

		/// <summary>
		/// 获取当前应用的返回码
		/// </summary>
		public static int ResultCode { get; private set; }

		/// <summary>
		/// 获取当前应用的 Api 版本
		/// </summary>
		public static int ApiVersion { get; private set; }

		/// <summary>
		/// 获取当前应用的名称
		/// </summary>
		public static string Name { get; private set; }

		/// <summary>
		/// 获取当前应用的版本号
		/// </summary>
		public static Version Version { get; private set; }

		/// <summary>
		/// 获取当前应用的顺序版本
		/// </summary>
		public static int VersionId { get; private set; }

		/// <summary>
		/// 获取当前应用的作者名
		/// </summary>
		public static string Author { get; private set; }

		/// <summary>
		/// 获取当前应用的说明文本
		/// </summary>
		public static string Description { get; private set; }
	}
}