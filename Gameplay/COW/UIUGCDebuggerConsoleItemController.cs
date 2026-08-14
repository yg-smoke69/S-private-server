using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023FB")]
public class UIUGCDebuggerConsoleItemController : UIEasyListItemController
{
	[Token(Token = "0x400E05B")]
	[FieldOffset(Offset = "0x38")]
	public Action<int> SelectCallback;

	[Token(Token = "0x400E05C")]
	[FieldOffset(Offset = "0x3C")]
	public Action<int, Vector3> LongPressCallback;

	[Token(Token = "0x400E05D")]
	[FieldOffset(Offset = "0x40")]
	private UIUGCDebuggerConsoleItemView m_View;

	[Token(Token = "0x400E05E")]
	[FieldOffset(Offset = "0x44")]
	private UIModelUGCDebugger.LogData m_data;

	[Token(Token = "0x600CB42")]
	[Address(RVA = "0x2B911A8", Offset = "0x2B911A8", VA = "0x2B911A8")]
	public UIUGCDebuggerConsoleItemController()
	{
	}

	[Token(Token = "0x600CB43")]
	[Address(RVA = "0x2B911B0", Offset = "0x2B911B0", VA = "0x2B911B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CB44")]
	[Address(RVA = "0x2B91254", Offset = "0x2B91254", VA = "0x2B91254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CB45")]
	[Address(RVA = "0x2B913B0", Offset = "0x2B913B0", VA = "0x2B913B0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CB46")]
	[Address(RVA = "0x2B91580", Offset = "0x2B91580", VA = "0x2B91580")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600CB47")]
	[Address(RVA = "0x2B91840", Offset = "0x2B91840", VA = "0x2B91840")]
	private void OnEditBtn()
	{
	}

	[Token(Token = "0x600CB48")]
	[Address(RVA = "0x2B91894", Offset = "0x2B91894", VA = "0x2B91894")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x600CB49")]
	[Address(RVA = "0x2B91908", Offset = "0x2B91908", VA = "0x2B91908")]
	private void OnLongPress()
	{
	}

	[Token(Token = "0x600CB4A")]
	[Address(RVA = "0x2B9195C", Offset = "0x2B9195C", VA = "0x2B9195C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CB4B")]
	[Address(RVA = "0x2B91A30", Offset = "0x2B91A30", VA = "0x2B91A30", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600CB4C")]
	[Address(RVA = "0x2B91A94", Offset = "0x2B91A94", VA = "0x2B91A94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CB4D")]
	[Address(RVA = "0x2B91A9C", Offset = "0x2B91A9C", VA = "0x2B91A9C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CB4E")]
	[Address(RVA = "0x2B91AA4", Offset = "0x2B91AA4", VA = "0x2B91AA4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
