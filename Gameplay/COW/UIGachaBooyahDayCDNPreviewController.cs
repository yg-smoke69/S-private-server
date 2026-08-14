using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002105")]
public class UIGachaBooyahDayCDNPreviewController : UIBaseController
{
	[Token(Token = "0x400CE95")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaBooyahDayCDNPreviewView m_View;

	[Token(Token = "0x600ABB0")]
	[Address(RVA = "0x265B084", Offset = "0x265B084", VA = "0x265B084")]
	public UIGachaBooyahDayCDNPreviewController()
	{
	}

	[Token(Token = "0x600ABB1")]
	[Address(RVA = "0x265B108", Offset = "0x265B108", VA = "0x265B108")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ABB2")]
	[Address(RVA = "0x265B1AC", Offset = "0x265B1AC", VA = "0x265B1AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ABB3")]
	[Address(RVA = "0x265B268", Offset = "0x265B268", VA = "0x265B268")]
	public UINetworkTexture GetCDNTexture()
	{
		return null;
	}

	[Token(Token = "0x600ABB4")]
	[Address(RVA = "0x265B2D8", Offset = "0x265B2D8", VA = "0x265B2D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
