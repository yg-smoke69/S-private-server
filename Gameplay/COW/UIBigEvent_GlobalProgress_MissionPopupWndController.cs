using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E98")]
public class UIBigEvent_GlobalProgress_MissionPopupWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400C058")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEvent_GlobalProgress_MissionPopupWndView m_View;

	[Token(Token = "0x400C059")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x6009391")]
	[Address(RVA = "0x10BE498", Offset = "0x10BE498", VA = "0x10BE498")]
	public UIBigEvent_GlobalProgress_MissionPopupWndController()
	{
	}

	[Token(Token = "0x6009392")]
	[Address(RVA = "0x10BE4A0", Offset = "0x10BE4A0", VA = "0x10BE4A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009393")]
	[Address(RVA = "0x10BE548", Offset = "0x10BE548", VA = "0x10BE548", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009394")]
	[Address(RVA = "0x10BEA40", Offset = "0x10BEA40", VA = "0x10BEA40", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009395")]
	[Address(RVA = "0x10BE9E0", Offset = "0x10BE9E0", VA = "0x10BE9E0")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009396")]
	[Address(RVA = "0x10BEE28", Offset = "0x10BEE28", VA = "0x10BEE28", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009397")]
	[Address(RVA = "0x10BEEF4", Offset = "0x10BEEF4", VA = "0x10BEEF4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009398")]
	[Address(RVA = "0x10BEF88", Offset = "0x10BEF88", VA = "0x10BEF88", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009399")]
	[Address(RVA = "0x10BF080", Offset = "0x10BF080", VA = "0x10BF080", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600939A")]
	[Address(RVA = "0x10BF17C", Offset = "0x10BF17C", VA = "0x10BF17C")]
	private void OnClickBtnClose()
	{
	}

	[Token(Token = "0x600939B")]
	[Address(RVA = "0x10BEB70", Offset = "0x10BEB70", VA = "0x10BEB70")]
	private void ReloadMissionList()
	{
	}

	[Token(Token = "0x600939C")]
	[Address(RVA = "0x10BF1E0", Offset = "0x10BF1E0", VA = "0x10BF1E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600939D")]
	[Address(RVA = "0x10BF1E8", Offset = "0x10BF1E8", VA = "0x10BF1E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
