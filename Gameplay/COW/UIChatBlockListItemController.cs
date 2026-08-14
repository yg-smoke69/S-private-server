using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002508")]
public class UIChatBlockListItemController : UIEasyListItemController
{
	[Token(Token = "0x400E5E8")]
	[FieldOffset(Offset = "0x38")]
	private UIChatBlockListItemView m_View;

	[Token(Token = "0x400E5E9")]
	[FieldOffset(Offset = "0x3C")]
	private ChatBlockUserInfo m_Info;

	[Token(Token = "0x600D6AC")]
	[Address(RVA = "0x262BFB4", Offset = "0x262BFB4", VA = "0x262BFB4")]
	public UIChatBlockListItemController()
	{
	}

	[Token(Token = "0x600D6AD")]
	[Address(RVA = "0x262BFBC", Offset = "0x262BFBC", VA = "0x262BFBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6AE")]
	[Address(RVA = "0x262C060", Offset = "0x262C060", VA = "0x262C060", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6AF")]
	[Address(RVA = "0x262C1BC", Offset = "0x262C1BC", VA = "0x262C1BC")]
	private void OnRemoveBtnClick()
	{
	}

	[Token(Token = "0x600D6B0")]
	[Address(RVA = "0x262C5D0", Offset = "0x262C5D0", VA = "0x262C5D0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D6B1")]
	[Address(RVA = "0x262C840", Offset = "0x262C840", VA = "0x262C840")]
	private void _003COnRemoveBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600D6B2")]
	[Address(RVA = "0x262C9BC", Offset = "0x262C9BC", VA = "0x262C9BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
