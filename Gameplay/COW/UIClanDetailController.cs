using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200253F")]
public class UIClanDetailController : UIPopupWindowController
{
	[Token(Token = "0x400E6CF")]
	[FieldOffset(Offset = "0x48")]
	private UIClanDetailsView m_View;

	[Token(Token = "0x400E6D0")]
	[FieldOffset(Offset = "0x4C")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x600D8C5")]
	[Address(RVA = "0x2F342D0", Offset = "0x2F342D0", VA = "0x2F342D0")]
	public UIClanDetailController()
	{
	}

	[Token(Token = "0x600D8C6")]
	[Address(RVA = "0x2F342D8", Offset = "0x2F342D8", VA = "0x2F342D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D8C7")]
	[Address(RVA = "0x2F3437C", Offset = "0x2F3437C", VA = "0x2F3437C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D8C8")]
	[Address(RVA = "0x2F344D0", Offset = "0x2F344D0", VA = "0x2F344D0")]
	public void SetUIdata(ClanInfoBasic claninfo, AccountInfoBasic clancaptaininfo)
	{
	}

	[Token(Token = "0x600D8C9")]
	[Address(RVA = "0x2F34BB8", Offset = "0x2F34BB8", VA = "0x2F34BB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
