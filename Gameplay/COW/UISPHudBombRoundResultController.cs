using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B29")]
internal class UISPHudBombRoundResultController : UIHudBaseCSRoundResultController
{
	[Token(Token = "0x4010916")]
	[FieldOffset(Offset = "0x3C")]
	private UISPHudBombRoundResultView m_View;

	[Token(Token = "0x4010917")]
	[FieldOffset(Offset = "0x40")]
	private UIModelSpectator m_ModelSpectator;

	[Token(Token = "0x6011C1F")]
	[Address(RVA = "0x1D0FCE0", Offset = "0x1D0FCE0", VA = "0x1D0FCE0")]
	public UISPHudBombRoundResultController()
	{
	}

	[Token(Token = "0x6011C20")]
	[Address(RVA = "0x1D0FCE8", Offset = "0x1D0FCE8", VA = "0x1D0FCE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C21")]
	[Address(RVA = "0x1D0FD90", Offset = "0x1D0FD90", VA = "0x1D0FD90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C22")]
	[Address(RVA = "0x1D0FF00", Offset = "0x1D0FF00", VA = "0x1D0FF00", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011C23")]
	[Address(RVA = "0x1D0FF64", Offset = "0x1D0FF64", VA = "0x1D0FF64", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011C24")]
	[Address(RVA = "0x1D0FFE0", Offset = "0x1D0FFE0", VA = "0x1D0FFE0")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x6011C25")]
	[Address(RVA = "0x1D102A4", Offset = "0x1D102A4", VA = "0x1D102A4")]
	private bool WinnerIsTeamA()
	{
		return default(bool);
	}

	[Token(Token = "0x6011C26")]
	[Address(RVA = "0x1D10510", Offset = "0x1D10510", VA = "0x1D10510")]
	private void SetFaction(TeamData team)
	{
	}

	[Token(Token = "0x6011C27")]
	[Address(RVA = "0x1D106F0", Offset = "0x1D106F0", VA = "0x1D106F0")]
	private bool _003CSetUIData_003Em__0(TeamData t)
	{
		return default(bool);
	}

	[Token(Token = "0x6011C28")]
	[Address(RVA = "0x1D10748", Offset = "0x1D10748", VA = "0x1D10748")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C29")]
	[Address(RVA = "0x1D10750", Offset = "0x1D10750", VA = "0x1D10750")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011C2A")]
	[Address(RVA = "0x1D10758", Offset = "0x1D10758", VA = "0x1D10758")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
