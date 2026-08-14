using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BA1")]
internal class UIUGCCSaveAsNewSlotController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010AEA")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCCSaveAsNewSlotView m_View;

	[Token(Token = "0x4010AEB")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIUGCSaveAsNewSlotItemController> m_CachedList;

	[Token(Token = "0x4010AEC")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditSlotInfo m_SelectedSlotInfo;

	[Token(Token = "0x6012077")]
	[Address(RVA = "0x2B7EEE0", Offset = "0x2B7EEE0", VA = "0x2B7EEE0")]
	public UIUGCCSaveAsNewSlotController()
	{
	}

	[Token(Token = "0x6012078")]
	[Address(RVA = "0x2B7EF6C", Offset = "0x2B7EF6C", VA = "0x2B7EF6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012079")]
	[Address(RVA = "0x2B7F014", Offset = "0x2B7F014", VA = "0x2B7F014", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601207A")]
	[Address(RVA = "0x2B7F150", Offset = "0x2B7F150", VA = "0x2B7F150")]
	public void SetUIData(SceneEditSlotInfo selected)
	{
	}

	[Token(Token = "0x601207B")]
	[Address(RVA = "0x2B7F4B4", Offset = "0x2B7F4B4", VA = "0x2B7F4B4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601207C")]
	[Address(RVA = "0x2B7F780", Offset = "0x2B7F780", VA = "0x2B7F780", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601207D")]
	[Address(RVA = "0x2B7F814", Offset = "0x2B7F814", VA = "0x2B7F814")]
	private void _003CSetUIData_003Em__0()
	{
	}

	[Token(Token = "0x601207E")]
	[Address(RVA = "0x2B7F81C", Offset = "0x2B7F81C", VA = "0x2B7F81C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
