using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B30")]
internal class UISPHudCSRoundResultItemController : UIBaseController
{
	[Token(Token = "0x401092B")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudCSRoundResultItemView m_View;

	[Token(Token = "0x6011C60")]
	[Address(RVA = "0x1D16E44", Offset = "0x1D16E44", VA = "0x1D16E44")]
	public UISPHudCSRoundResultItemController()
	{
	}

	[Token(Token = "0x6011C61")]
	[Address(RVA = "0x1D16EC8", Offset = "0x1D16EC8", VA = "0x1D16EC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C62")]
	[Address(RVA = "0x1D16F70", Offset = "0x1D16F70", VA = "0x1D16F70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C63")]
	[Address(RVA = "0x1D1702C", Offset = "0x1D1702C", VA = "0x1D1702C", Slot = "31")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6011C64")]
	[Address(RVA = "0x1D17300", Offset = "0x1D17300", VA = "0x1D17300")]
	public void SetRoundId(int roundId)
	{
	}

	[Token(Token = "0x6011C65")]
	[Address(RVA = "0x1D173B8", Offset = "0x1D173B8", VA = "0x1D173B8", Slot = "32")]
	public virtual void OnTeamWin(bool winOnLeft, byte winReason)
	{
	}

	[Token(Token = "0x6011C66")]
	[Address(RVA = "0x1D17684", Offset = "0x1D17684", VA = "0x1D17684")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
