using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024AA")]
public class UIAvatarLevelUpItemController : UIBaseController
{
	[Token(Token = "0x400E32A")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarLevelUpItemView m_View;

	[Token(Token = "0x400E32B")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_ctrl;

	[Token(Token = "0x600D1D9")]
	[Address(RVA = "0x2A80E88", Offset = "0x2A80E88", VA = "0x2A80E88")]
	public UIAvatarLevelUpItemController()
	{
	}

	[Token(Token = "0x600D1DA")]
	[Address(RVA = "0x2A80F0C", Offset = "0x2A80F0C", VA = "0x2A80F0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1DB")]
	[Address(RVA = "0x2A80FB4", Offset = "0x2A80FB4", VA = "0x2A80FB4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1DC")]
	[Address(RVA = "0x2A81070", Offset = "0x2A81070", VA = "0x2A81070")]
	public void RefreshData(AvatarLevelUpItem itemdata)
	{
	}

	[Token(Token = "0x600D1DD")]
	[Address(RVA = "0x2A8147C", Offset = "0x2A8147C", VA = "0x2A8147C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
