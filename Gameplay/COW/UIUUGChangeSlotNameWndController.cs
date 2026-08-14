using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002369")]
public class UIUUGChangeSlotNameWndController : UIPopupWindowController
{
	[Token(Token = "0x400DC74")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditSlotNameWndView m_View;

	[Token(Token = "0x400DC75")]
	[FieldOffset(Offset = "0x4C")]
	private SceneEditSlotInfo m_slotInfo;

	[Token(Token = "0x600C595")]
	[Address(RVA = "0xF44F9C", Offset = "0xF44F9C", VA = "0xF44F9C")]
	public UIUUGChangeSlotNameWndController()
	{
	}

	[Token(Token = "0x600C596")]
	[Address(RVA = "0xF44FA4", Offset = "0xF44FA4", VA = "0xF44FA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C597")]
	[Address(RVA = "0xF45048", Offset = "0xF45048", VA = "0xF45048", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C598")]
	[Address(RVA = "0xF45218", Offset = "0xF45218", VA = "0xF45218")]
	private void OnClickCancelBtn()
	{
	}

	[Token(Token = "0x600C599")]
	[Address(RVA = "0xF4527C", Offset = "0xF4527C", VA = "0xF4527C")]
	public void SetSlotInfo(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C59A")]
	[Address(RVA = "0xF4533C", Offset = "0xF4533C", VA = "0xF4533C")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x600C59B")]
	[Address(RVA = "0xF4561C", Offset = "0xF4561C", VA = "0xF4561C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
