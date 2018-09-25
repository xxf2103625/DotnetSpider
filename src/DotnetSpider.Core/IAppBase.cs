﻿namespace DotnetSpider.Core
{
	/// <summary>
	/// 标准任务接口
	/// </summary>
	public interface IAppBase : IRunable, IIdentity, ITask, INamed
	{
	}
}
