using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028BF")]
public class UIHudWereWolvesTaskListController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FACF")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesTaskListView m_View;

	[Token(Token = "0x400FAD0")]
	[FieldOffset(Offset = "0x2C")]
	private List<FPODNGHHILN> m_TaskList;

	[Token(Token = "0x60100AA")]
	[Address(RVA = "0x25700A4", Offset = "0x25700A4", VA = "0x25700A4")]
	public UIHudWereWolvesTaskListController()
	{
	}

	[Token(Token = "0x60100AB")]
	[Address(RVA = "0x2570128", Offset = "0x2570128", VA = "0x2570128")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60100AC")]
	[Address(RVA = "0x25701D0", Offset = "0x25701D0", VA = "0x25701D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60100AD")]
	[Address(RVA = "0x25703C4", Offset = "0x25703C4", VA = "0x25703C4", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60100AE")]
	[Address(RVA = "0x2570560", Offset = "0x2570560", VA = "0x2570560", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60100AF")]
	[Address(RVA = "0x2570624", Offset = "0x2570624", VA = "0x2570624")]
	private void OnRefreshTaskList(object[] data)
	{
	}

	[Token(Token = "0x60100B0")]
	[Address(RVA = "0x2570800", Offset = "0x2570800", VA = "0x2570800", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60100B1")]
	[Address(RVA = "0x2570930", Offset = "0x2570930", VA = "0x2570930", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60100B2")]
	[Address(RVA = "0x25709AC", Offset = "0x25709AC", VA = "0x25709AC")]
	private void OnShowTaskList(object[] data)
	{
	}

	[Token(Token = "0x60100B3")]
	[Address(RVA = "0x2570AB8", Offset = "0x2570AB8", VA = "0x2570AB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60100B4")]
	[Address(RVA = "0x2570AC0", Offset = "0x2570AC0", VA = "0x2570AC0")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x60100B5")]
	[Address(RVA = "0x2570AC8", Offset = "0x2570AC8", VA = "0x2570AC8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
