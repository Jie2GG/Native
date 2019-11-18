﻿using Native.Csharp.Sdk.Cqp.Enum;
using Native.Csharp.Sdk.Cqp.Expand;
using Native.Csharp.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Sdk.Cqp.EventArgs
{
	/// <summary>
	/// 提供用于描述酷Q群禁言事件参数的类
	/// <para/>
	/// Type: 104
	/// </summary>
	public class CQGroupBanSpeakEventeArgs : CQEventEventArgs
	{
		#region --属性--
		/// <summary>
		/// 获取当前事件的子类型
		/// </summary>
		public CQGroupBanSpeakType SubType { get; private set; }

		/// <summary>
		/// 获取当前事件的发送时间
		/// </summary>
		public DateTime SendTime { get; private set; }

		/// <summary>
		/// 获取当前事件的来源群
		/// </summary>
		public Group FromGroup { get; private set; }

		/// <summary>
		/// 获取当前事件的来源QQ
		/// </summary>
		public QQ FromQQ { get; private set; }

		/// <summary>
		/// 获取当前事件的被操作QQ
		/// </summary>
		public QQ BeingOperateQQ { get; private set; }

		/// <summary>
		/// 获取当前事件的禁言时长, 此值仅在  <see cref="SubType"/> 是 <see cref="CQGroupBanSpeakType.SetBanSpeak"/> 时可用
		/// </summary>
		public TimeSpan? BanSpeakTimeSpan { get; private set; }
		#endregion

		#region --构造函数--
		/// <summary>
		/// 初始化 <see cref="CQGroupBanSpeakEventeArgs"/> 类的新实例
		/// </summary>
		/// <param name="id">事件Id</param>
		/// <param name="type">事件类型</param>
		/// <param name="name">事件名称</param>
		/// <param name="function">函数名称</param>
		/// <param name="priority">默认优先级</param>
		/// <param name="subType">子类型</param>
		/// <param name="sendTime">发送时间</param>
		/// <param name="fromGroup">来源群</param>
		/// <param name="fromQQ">来源QQ</param>
		/// <param name="beingOperateQQ">被操作QQ</param>
		/// <param name="duration">禁言时长, 单位: 秒</param>
		/// <param name="api">接口Api实例</param>
		public CQGroupBanSpeakEventeArgs (int id, int type, string name, string function, uint priority, int subType, int sendTime, long fromGroup, long fromQQ, long beingOperateQQ, long duration, CQApi api)
			: base (id, type, name, function, priority)
		{
			this.SubType = (CQGroupBanSpeakType)subType;
			this.SendTime = sendTime.ToDateTime ();
			this.FromGroup = new Group (api, fromGroup);
			this.FromQQ = new QQ (api, fromQQ);
			this.BeingOperateQQ = new QQ (api, beingOperateQQ);
			this.BanSpeakTimeSpan = TimeSpan.FromSeconds (duration);
		}
		#endregion
	}
}