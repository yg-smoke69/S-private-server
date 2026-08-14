using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B7C")]
public class UITrainingCampMsgWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x4010A61")]
	[FieldOffset(Offset = "0x48")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x4010A62")]
	[FieldOffset(Offset = "0x4C")]
	private UITrainingCampMsgWndView m_View;

	[Token(Token = "0x6011F5A")]
	[Address(RVA = "0x1C1DCA4", Offset = "0x1C1DCA4", VA = "0x1C1DCA4")]
	public UITrainingCampMsgWndController()
	{
	}

	[Token(Token = "0x6011F5B")]
	[Address(RVA = "0x1C1DCAC", Offset = "0x1C1DCAC", VA = "0x1C1DCAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F5C")]
	[Address(RVA = "0x1C1DD50", Offset = "0x1C1DD50", VA = "0x1C1DD50", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011F5D")]
	[Address(RVA = "0x1C1DDCC", Offset = "0x1C1DDCC", VA = "0x1C1DDCC", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011F5E")]
	[Address(RVA = "0x1C1E094", Offset = "0x1C1E094", VA = "0x1C1E094", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011F5F")]
	[Address(RVA = "0x1C1E128", Offset = "0x1C1E128", VA = "0x1C1E128", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011F60")]
	[Address(RVA = "0x1C1E220", Offset = "0x1C1E220", VA = "0x1C1E220", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F61")]
	[Address(RVA = "0x1C1DE98", Offset = "0x1C1DE98", VA = "0x1C1DE98")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6011F62")]
	[Address(RVA = "0x1C1E3A4", Offset = "0x1C1E3A4", VA = "0x1C1E3A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
