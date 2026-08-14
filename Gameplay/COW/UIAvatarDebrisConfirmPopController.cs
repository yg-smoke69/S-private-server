using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A6")]
public class UIAvatarDebrisConfirmPopController : UIPopupWindowController
{
	[Token(Token = "0x400E31F")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarDebrisConfirmPopView m_View;

	[Token(Token = "0x400E320")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_AvatarId;

	[Token(Token = "0x600D1BA")]
	[Address(RVA = "0x2A7EB28", Offset = "0x2A7EB28", VA = "0x2A7EB28")]
	public UIAvatarDebrisConfirmPopController()
	{
	}

	[Token(Token = "0x600D1BB")]
	[Address(RVA = "0x2A7EB30", Offset = "0x2A7EB30", VA = "0x2A7EB30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1BC")]
	[Address(RVA = "0x2A7EBD8", Offset = "0x2A7EBD8", VA = "0x2A7EBD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1BD")]
	[Address(RVA = "0x2A7EDA8", Offset = "0x2A7EDA8", VA = "0x2A7EDA8")]
	public void SetAvatarId(uint id)
	{
	}

	[Token(Token = "0x600D1BE")]
	[Address(RVA = "0x2A7EE08", Offset = "0x2A7EE08", VA = "0x2A7EE08")]
	private void OnLevelUp()
	{
	}

	[Token(Token = "0x600D1BF")]
	[Address(RVA = "0x2A7EF54", Offset = "0x2A7EF54", VA = "0x2A7EF54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1C0")]
	[Address(RVA = "0x2A7EFB8", Offset = "0x2A7EFB8", VA = "0x2A7EFB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1C1")]
	[Address(RVA = "0x2A7EFC0", Offset = "0x2A7EFC0", VA = "0x2A7EFC0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
