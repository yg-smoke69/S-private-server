using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028C1")]
public class UIHudWereWolvesTaskWolfListController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FAD3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesTaskWolfListView m_View;

	[Token(Token = "0x400FAD4")]
	[FieldOffset(Offset = "0x2C")]
	private List<ALIODAIDAID> m_TaskList;

	[Token(Token = "0x60100BB")]
	[Address(RVA = "0x25718C0", Offset = "0x25718C0", VA = "0x25718C0")]
	public UIHudWereWolvesTaskWolfListController()
	{
	}

	[Token(Token = "0x60100BC")]
	[Address(RVA = "0x2571944", Offset = "0x2571944", VA = "0x2571944")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60100BD")]
	[Address(RVA = "0x25719EC", Offset = "0x25719EC", VA = "0x25719EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60100BE")]
	[Address(RVA = "0x2571CF4", Offset = "0x2571CF4", VA = "0x2571CF4", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60100BF")]
	[Address(RVA = "0x2571E90", Offset = "0x2571E90", VA = "0x2571E90", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60100C0")]
	[Address(RVA = "0x25721AC", Offset = "0x25721AC", VA = "0x25721AC")]
	private void ShowList(bool value)
	{
	}

	[Token(Token = "0x60100C1")]
	[Address(RVA = "0x257227C", Offset = "0x257227C", VA = "0x257227C")]
	private void OnExpandClick()
	{
	}

	[Token(Token = "0x60100C2")]
	[Address(RVA = "0x25722E0", Offset = "0x25722E0", VA = "0x25722E0")]
	private void OnShrinkClick()
	{
	}

	[Token(Token = "0x60100C3")]
	[Address(RVA = "0x2571F60", Offset = "0x2571F60", VA = "0x2571F60")]
	private void OnRefreshTaskList(object[] data)
	{
	}

	[Token(Token = "0x60100C4")]
	[Address(RVA = "0x2572344", Offset = "0x2572344", VA = "0x2572344")]
	private int Cmp(ALIODAIDAID infoA, ALIODAIDAID infoB)
	{
		return default(int);
	}

	[Token(Token = "0x60100C5")]
	[Address(RVA = "0x2572408", Offset = "0x2572408", VA = "0x2572408", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60100C6")]
	[Address(RVA = "0x2572538", Offset = "0x2572538", VA = "0x2572538", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60100C7")]
	[Address(RVA = "0x25725B4", Offset = "0x25725B4", VA = "0x25725B4")]
	private void OnShowTaskList(object[] data)
	{
	}

	[Token(Token = "0x60100C8")]
	[Address(RVA = "0x25726C0", Offset = "0x25726C0", VA = "0x25726C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60100C9")]
	[Address(RVA = "0x25726C8", Offset = "0x25726C8", VA = "0x25726C8")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x60100CA")]
	[Address(RVA = "0x25726D0", Offset = "0x25726D0", VA = "0x25726D0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
