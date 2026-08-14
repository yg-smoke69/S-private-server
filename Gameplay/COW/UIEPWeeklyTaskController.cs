using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020E6")]
public class UIEPWeeklyTaskController : UIBaseController
{
	[Token(Token = "0x400CDD4")]
	[FieldOffset(Offset = "0x28")]
	private UIEPWeeklyTaskView m_View;

	[Token(Token = "0x400CDD5")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIEPWeeklyItemPreviewController> m_TaskItemList;

	[Token(Token = "0x400CDD6")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPWeeklyQuestGroupData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600AA5B")]
	[Address(RVA = "0x2BB80F4", Offset = "0x2BB80F4", VA = "0x2BB80F4")]
	public UIEPWeeklyTaskController()
	{
	}

	[Token(Token = "0x600AA5C")]
	[Address(RVA = "0x2BB81AC", Offset = "0x2BB81AC", VA = "0x2BB81AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA5D")]
	[Address(RVA = "0x2BB8250", Offset = "0x2BB8250", VA = "0x2BB8250", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA5E")]
	[Address(RVA = "0x2BB8460", Offset = "0x2BB8460", VA = "0x2BB8460", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AA5F")]
	[Address(RVA = "0x2BB8594", Offset = "0x2BB8594", VA = "0x2BB8594")]
	private void OnEPQuestUpdate(object[] data)
	{
	}

	[Token(Token = "0x600AA60")]
	[Address(RVA = "0x2BB8400", Offset = "0x2BB8400", VA = "0x2BB8400")]
	private void InitData()
	{
	}

	[Token(Token = "0x600AA61")]
	[Address(RVA = "0x2BB8674", Offset = "0x2BB8674", VA = "0x2BB8674")]
	private void RefreshTaskList()
	{
	}

	[Token(Token = "0x600AA62")]
	[Address(RVA = "0x2BB8DD4", Offset = "0x2BB8DD4", VA = "0x2BB8DD4")]
	private static int _003CRefreshTaskList_003Em__0(EPWeeklyQuestGroupData a, EPWeeklyQuestGroupData b)
	{
		return default(int);
	}

	[Token(Token = "0x600AA63")]
	[Address(RVA = "0x2BB8E14", Offset = "0x2BB8E14", VA = "0x2BB8E14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA64")]
	[Address(RVA = "0x2BB8E1C", Offset = "0x2BB8E1C", VA = "0x2BB8E1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
