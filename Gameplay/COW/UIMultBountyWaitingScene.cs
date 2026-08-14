using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003329")]
internal class UIMultBountyWaitingScene : UIInGameScene
{
	[Token(Token = "0x40137F8")]
	[FieldOffset(Offset = "0x2C8")]
	private JLJPMNODJGA m_CurState;

	[Token(Token = "0x40137F9")]
	[FieldOffset(Offset = "0x2CC")]
	private BountyRepairingRankController m_RankController;

	[Token(Token = "0x40137FA")]
	[FieldOffset(Offset = "0x2D0")]
	private BountyRepairingProgressController m_ProgressController;

	[Token(Token = "0x40137FB")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudPopupController m_TipUI;

	[Token(Token = "0x6015ACB")]
	[Address(RVA = "0x1951860", Offset = "0x1951860", VA = "0x1951860")]
	public UIMultBountyWaitingScene()
	{
	}

	[Token(Token = "0x6015ACC")]
	[Address(RVA = "0x19518E4", Offset = "0x19518E4", VA = "0x19518E4", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015ACD")]
	[Address(RVA = "0x1951A18", Offset = "0x1951A18", VA = "0x1951A18")]
	private void OnTeleportMachineStateCome(object[] param)
	{
	}

	[Token(Token = "0x6015ACE")]
	[Address(RVA = "0x1951F30", Offset = "0x1951F30", VA = "0x1951F30")]
	public void ShowRepairTip(string str)
	{
	}

	[Token(Token = "0x6015ACF")]
	[Address(RVA = "0x1951C78", Offset = "0x1951C78", VA = "0x1951C78")]
	private void OpenRankController()
	{
	}

	[Token(Token = "0x6015AD0")]
	[Address(RVA = "0x1951DCC", Offset = "0x1951DCC", VA = "0x1951DCC")]
	private void OpenProgressController()
	{
	}

	[Token(Token = "0x6015AD1")]
	[Address(RVA = "0x1952054", Offset = "0x1952054", VA = "0x1952054")]
	public void CloseFakeLoadingMask()
	{
	}

	[Token(Token = "0x6015AD2")]
	[Address(RVA = "0x19520B8", Offset = "0x19520B8", VA = "0x19520B8", Slot = "19")]
	protected override void CloseHUDMask()
	{
	}

	[Token(Token = "0x6015AD3")]
	[Address(RVA = "0x195210C", Offset = "0x195210C", VA = "0x195210C")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AD4")]
	[Address(RVA = "0x1952114", Offset = "0x1952114", VA = "0x1952114")]
	public void _003C_003EiFixBaseProxy_CloseHUDMask()
	{
	}
}
