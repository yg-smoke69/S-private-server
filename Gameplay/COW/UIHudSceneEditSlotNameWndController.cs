using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002348")]
public class UIHudSceneEditSlotNameWndController : UIPopupWindowController
{
	[Token(Token = "0x400DBD2")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditSlotNameWndView m_View;

	[Token(Token = "0x400DBD3")]
	[FieldOffset(Offset = "0x4C")]
	private SceneEditSlotInfo m_slotInfo;

	[Token(Token = "0x600C483")]
	[Address(RVA = "0x16B6E54", Offset = "0x16B6E54", VA = "0x16B6E54")]
	public UIHudSceneEditSlotNameWndController()
	{
	}

	[Token(Token = "0x600C484")]
	[Address(RVA = "0x16B6E5C", Offset = "0x16B6E5C", VA = "0x16B6E5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C485")]
	[Address(RVA = "0x16B6F00", Offset = "0x16B6F00", VA = "0x16B6F00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C486")]
	[Address(RVA = "0x16B71A8", Offset = "0x16B71A8", VA = "0x16B71A8")]
	private void OnClickCancelBtn()
	{
	}

	[Token(Token = "0x600C487")]
	[Address(RVA = "0x16B1C8C", Offset = "0x16B1C8C", VA = "0x16B1C8C")]
	public void SetSlotInfo(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C488")]
	[Address(RVA = "0x16B1CEC", Offset = "0x16B1CEC", VA = "0x16B1CEC")]
	public void SetCurSlotName(string name)
	{
	}

	[Token(Token = "0x600C489")]
	[Address(RVA = "0x16B720C", Offset = "0x16B720C", VA = "0x16B720C")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x600C48A")]
	[Address(RVA = "0x16B75BC", Offset = "0x16B75BC", VA = "0x16B75BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
