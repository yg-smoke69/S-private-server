using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002077")]
internal class UICupMatchProfileItemController : UIBaseController
{
	[Token(Token = "0x400CB89")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchProfileItemView m_View;

	[Token(Token = "0x400CB8A")]
	[FieldOffset(Offset = "0x2C")]
	private UINetworkTexture m_HeadTexture;

	[Token(Token = "0x400CB8B")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_HeadIcon;

	[Token(Token = "0x600A695")]
	[Address(RVA = "0x2AA9DD4", Offset = "0x2AA9DD4", VA = "0x2AA9DD4")]
	public UICupMatchProfileItemController()
	{
	}

	[Token(Token = "0x600A696")]
	[Address(RVA = "0x2AA9E58", Offset = "0x2AA9E58", VA = "0x2AA9E58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A697")]
	[Address(RVA = "0x2AA9F00", Offset = "0x2AA9F00", VA = "0x2AA9F00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A698")]
	[Address(RVA = "0x2AA9FB0", Offset = "0x2AA9FB0", VA = "0x2AA9FB0")]
	public void SetViewData(bool isRight, BaseProfileInfo info, bool isLeader = false)
	{
	}

	[Token(Token = "0x600A699")]
	[Address(RVA = "0x2AAA490", Offset = "0x2AAA490", VA = "0x2AAA490")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
