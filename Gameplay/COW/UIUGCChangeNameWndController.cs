using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B91")]
public class UIUGCChangeNameWndController : UIPopupWindowController
{
	[Token(Token = "0x4010AB7")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCChangeNameWndView m_View;

	[Token(Token = "0x4010AB8")]
	[FieldOffset(Offset = "0x4C")]
	private SceneEditSlotInfo m_slotInfo;

	[Token(Token = "0x601201C")]
	[Address(RVA = "0x2B819B4", Offset = "0x2B819B4", VA = "0x2B819B4")]
	public UIUGCChangeNameWndController()
	{
	}

	[Token(Token = "0x601201D")]
	[Address(RVA = "0x2B819BC", Offset = "0x2B819BC", VA = "0x2B819BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601201E")]
	[Address(RVA = "0x2B81A64", Offset = "0x2B81A64", VA = "0x2B81A64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601201F")]
	[Address(RVA = "0x2B81C34", Offset = "0x2B81C34", VA = "0x2B81C34")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x6012020")]
	[Address(RVA = "0x2B81C98", Offset = "0x2B81C98", VA = "0x2B81C98")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x6012021")]
	[Address(RVA = "0x2B81F84", Offset = "0x2B81F84", VA = "0x2B81F84")]
	public void SetSlotInfo(SceneEditSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6012022")]
	[Address(RVA = "0x2B82038", Offset = "0x2B82038", VA = "0x2B82038")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
