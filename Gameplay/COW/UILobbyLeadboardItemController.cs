using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002927")]
internal class UILobbyLeadboardItemController : UIBaseController
{
	[Token(Token = "0x400FD76")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyLeaderBoardItemView m_View;

	[Token(Token = "0x601059B")]
	[Address(RVA = "0xDBA838", Offset = "0xDBA838", VA = "0xDBA838")]
	public UILobbyLeadboardItemController()
	{
	}

	[Token(Token = "0x601059C")]
	[Address(RVA = "0xDBA8BC", Offset = "0xDBA8BC", VA = "0xDBA8BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601059D")]
	[Address(RVA = "0xDBA960", Offset = "0xDBA960", VA = "0xDBA960", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601059E")]
	[Address(RVA = "0xDBAAC4", Offset = "0xDBAAC4", VA = "0xDBAAC4")]
	public void SetTop3Rank(int rankNum)
	{
	}

	[Token(Token = "0x601059F")]
	[Address(RVA = "0xDBABAC", Offset = "0xDBABAC", VA = "0xDBABAC")]
	public void SetData(LeaderBoardInfo info)
	{
	}

	[Token(Token = "0x60105A0")]
	[Address(RVA = "0xDBAD14", Offset = "0xDBAD14", VA = "0xDBAD14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
