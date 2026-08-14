using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020E8")]
public class UIEPWeeklyTaskDetailListController : UIBaseController, _Attribute
{
	[Token(Token = "0x400CDDB")]
	[FieldOffset(Offset = "0x28")]
	private UIEPWeeklyTaskDetailListView m_View;

	[Token(Token = "0x400CDDC")]
	[FieldOffset(Offset = "0x2C")]
	private List<EPWeeklyQuestInfo> m_Data;

	[Token(Token = "0x600AA70")]
	[Address(RVA = "0x2A38288", Offset = "0x2A38288", VA = "0x2A38288")]
	public UIEPWeeklyTaskDetailListController()
	{
	}

	[Token(Token = "0x600AA71")]
	[Address(RVA = "0x2A3830C", Offset = "0x2A3830C", VA = "0x2A3830C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA72")]
	[Address(RVA = "0x2A383B0", Offset = "0x2A383B0", VA = "0x2A383B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA73")]
	[Address(RVA = "0x2A3853C", Offset = "0x2A3853C", VA = "0x2A3853C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AA74")]
	[Address(RVA = "0x2A38670", Offset = "0x2A38670", VA = "0x2A38670")]
	private void OnEPQuestUpdate(object[] data)
	{
	}

	[Token(Token = "0x600AA75")]
	[Address(RVA = "0x2A38820", Offset = "0x2A38820", VA = "0x2A38820")]
	private void RefreshProcess()
	{
	}

	[Token(Token = "0x600AA76")]
	[Address(RVA = "0x2A38FE8", Offset = "0x2A38FE8", VA = "0x2A38FE8")]
	private void InitData()
	{
	}

	[Token(Token = "0x600AA77")]
	[Address(RVA = "0x2A38E6C", Offset = "0x2A38E6C", VA = "0x2A38E6C")]
	private void RefreshQuestList()
	{
	}

	[Token(Token = "0x600AA78")]
	[Address(RVA = "0x2A3924C", Offset = "0x2A3924C", VA = "0x2A3924C")]
	private int SortQuestList(EPWeeklyQuestInfo x, EPWeeklyQuestInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600AA79")]
	[Address(RVA = "0x2A393A4", Offset = "0x2A393A4", VA = "0x2A393A4")]
	public void SetData(List<EPWeeklyQuestInfo> info)
	{
	}

	[Token(Token = "0x600AA7A")]
	[Address(RVA = "0x2A39410", Offset = "0x2A39410", VA = "0x2A39410", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AA7B")]
	[Address(RVA = "0x2A39508", Offset = "0x2A39508", VA = "0x2A39508", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600AA7C")]
	[Address(RVA = "0x2A39584", Offset = "0x2A39584", VA = "0x2A39584")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA7D")]
	[Address(RVA = "0x2A3958C", Offset = "0x2A3958C", VA = "0x2A3958C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
