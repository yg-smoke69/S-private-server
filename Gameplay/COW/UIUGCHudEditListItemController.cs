using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002428")]
public class UIUGCHudEditListItemController : UIEasyListItemController
{
	[Token(Token = "0x400E108")]
	[FieldOffset(Offset = "0x38")]
	public Action<int> SelectCallback;

	[Token(Token = "0x400E109")]
	[FieldOffset(Offset = "0x3C")]
	public Action<int, Vector3> LongPressCallback;

	[Token(Token = "0x400E10A")]
	[FieldOffset(Offset = "0x40")]
	private UIUGCHudEditListItemView m_View;

	[Token(Token = "0x400E10B")]
	[FieldOffset(Offset = "0x44")]
	private AONDOMHABOH m_Data;

	[Token(Token = "0x400E10C")]
	[FieldOffset(Offset = "0x0")]
	private static Color s_SelectedColor;

	[Token(Token = "0x400E10D")]
	[FieldOffset(Offset = "0x10")]
	private static Color s_DefaultColor;

	[Token(Token = "0x600CCC9")]
	[Address(RVA = "0x2FEBD28", Offset = "0x2FEBD28", VA = "0x2FEBD28")]
	public UIUGCHudEditListItemController()
	{
	}

	[Token(Token = "0x600CCCA")]
	[Address(RVA = "0x2FEBD30", Offset = "0x2FEBD30", VA = "0x2FEBD30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CCCB")]
	[Address(RVA = "0x2FEBDD4", Offset = "0x2FEBDD4", VA = "0x2FEBDD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CCCC")]
	[Address(RVA = "0x2FEC02C", Offset = "0x2FEC02C", VA = "0x2FEC02C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CCCD")]
	[Address(RVA = "0x2FEBB90", Offset = "0x2FEBB90", VA = "0x2FEBB90")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600CCCE")]
	[Address(RVA = "0x2FEC134", Offset = "0x2FEC134", VA = "0x2FEC134")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x600CCCF")]
	[Address(RVA = "0x2FEC284", Offset = "0x2FEC284", VA = "0x2FEC284")]
	private void OnClickMenuBtn()
	{
	}

	[Token(Token = "0x600CCD0")]
	[Address(RVA = "0x2FEC3A8", Offset = "0x2FEC3A8", VA = "0x2FEC3A8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CCD1")]
	[Address(RVA = "0x2FEC5EC", Offset = "0x2FEC5EC", VA = "0x2FEC5EC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600CCD3")]
	[Address(RVA = "0x2FEC8C4", Offset = "0x2FEC8C4", VA = "0x2FEC8C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CCD4")]
	[Address(RVA = "0x2FEC8CC", Offset = "0x2FEC8CC", VA = "0x2FEC8CC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600CCD5")]
	[Address(RVA = "0x2FEC8D4", Offset = "0x2FEC8D4", VA = "0x2FEC8D4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
