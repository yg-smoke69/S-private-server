using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200205C")]
internal class UIHudCSSORoundStartController : UIBaseController
{
	[Token(Token = "0x400CADB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSSORoundStartView m_View;

	[Token(Token = "0x400CADC")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CADD")]
	[FieldOffset(Offset = "0x30")]
	private BIKDLLIBDKE m_Game;

	[Token(Token = "0x400CADE")]
	[FieldOffset(Offset = "0x34")]
	private byte m_MyTeamID;

	[Token(Token = "0x400CADF")]
	[FieldOffset(Offset = "0x35")]
	private byte m_CurrRoundOppoTeamID;

	[Token(Token = "0x600A574")]
	[Address(RVA = "0x2135C2C", Offset = "0x2135C2C", VA = "0x2135C2C")]
	public UIHudCSSORoundStartController()
	{
	}

	[Token(Token = "0x600A575")]
	[Address(RVA = "0x2135CB0", Offset = "0x2135CB0", VA = "0x2135CB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A576")]
	[Address(RVA = "0x2135D58", Offset = "0x2135D58", VA = "0x2135D58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A577")]
	[Address(RVA = "0x2135F14", Offset = "0x2135F14", VA = "0x2135F14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A578")]
	[Address(RVA = "0x2135F78", Offset = "0x2135F78", VA = "0x2135F78", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A579")]
	[Address(RVA = "0x213633C", Offset = "0x213633C", VA = "0x213633C")]
	private void SetCurrRound()
	{
	}

	[Token(Token = "0x600A57A")]
	[Address(RVA = "0x213654C", Offset = "0x213654C", VA = "0x213654C")]
	private void SetGameZoneInfo()
	{
	}

	[Token(Token = "0x600A57B")]
	[Address(RVA = "0x2136870", Offset = "0x2136870", VA = "0x2136870")]
	private void SetTeamInfo()
	{
	}

	[Token(Token = "0x600A57C")]
	[Address(RVA = "0x2136D4C", Offset = "0x2136D4C", VA = "0x2136D4C")]
	private void SetPlayerNum()
	{
	}

	[Token(Token = "0x600A57D")]
	[Address(RVA = "0x213703C", Offset = "0x213703C", VA = "0x213703C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A57E")]
	[Address(RVA = "0x2137044", Offset = "0x2137044", VA = "0x2137044")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A57F")]
	[Address(RVA = "0x213704C", Offset = "0x213704C", VA = "0x213704C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
