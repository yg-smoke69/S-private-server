using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20021A9")]
internal class UIHudLWSORoundStartController : UIBaseController
{
	[Token(Token = "0x400D2E3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSORoundStartView m_View;

	[Token(Token = "0x400D2E4")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D2E5")]
	[FieldOffset(Offset = "0x30")]
	private ANBHLMNFJMP m_Game;

	[Token(Token = "0x400D2E6")]
	[FieldOffset(Offset = "0x34")]
	private byte m_MyTeamID;

	[Token(Token = "0x400D2E7")]
	[FieldOffset(Offset = "0x38")]
	private List<UISprite> m_MyTeamHP;

	[Token(Token = "0x400D2E8")]
	[FieldOffset(Offset = "0x3C")]
	private List<UISprite> m_OppoTeamHP;

	[Token(Token = "0x400D2E9")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Inited;

	[Token(Token = "0x600B2EB")]
	[Address(RVA = "0x1BCDCE4", Offset = "0x1BCDCE4", VA = "0x1BCDCE4")]
	public UIHudLWSORoundStartController()
	{
	}

	[Token(Token = "0x600B2EC")]
	[Address(RVA = "0x1BCDDB4", Offset = "0x1BCDDB4", VA = "0x1BCDDB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B2ED")]
	[Address(RVA = "0x1BCDE5C", Offset = "0x1BCDE5C", VA = "0x1BCDE5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B2EE")]
	[Address(RVA = "0x1BCE064", Offset = "0x1BCE064", VA = "0x1BCE064", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B2EF")]
	[Address(RVA = "0x1BCE0C8", Offset = "0x1BCE0C8", VA = "0x1BCE0C8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B2F0")]
	[Address(RVA = "0x1BCE73C", Offset = "0x1BCE73C", VA = "0x1BCE73C")]
	private void SetCurrRound()
	{
	}

	[Token(Token = "0x600B2F1")]
	[Address(RVA = "0x1BCE94C", Offset = "0x1BCE94C", VA = "0x1BCE94C")]
	private void SetGameZoneInfo()
	{
	}

	[Token(Token = "0x600B2F2")]
	[Address(RVA = "0x1BCEBAC", Offset = "0x1BCEBAC", VA = "0x1BCEBAC")]
	private void SetTeamInfo()
	{
	}

	[Token(Token = "0x600B2F3")]
	[Address(RVA = "0x1BCF33C", Offset = "0x1BCF33C", VA = "0x1BCF33C")]
	private void SetTeamFactionIcon(UISprite sprite, MHAKBOKLPMP identity, bool isSelf)
	{
	}

	[Token(Token = "0x600B2F4")]
	[Address(RVA = "0x1BCEFC4", Offset = "0x1BCEFC4", VA = "0x1BCEFC4")]
	private void SetTeamName(byte teamID, UILabel teamNameLabel)
	{
	}

	[Token(Token = "0x600B2F5")]
	[Address(RVA = "0x1BCE384", Offset = "0x1BCE384", VA = "0x1BCE384")]
	private void InitTeamHP()
	{
	}

	[Token(Token = "0x600B2F6")]
	[Address(RVA = "0x1BCF45C", Offset = "0x1BCF45C", VA = "0x1BCF45C")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600B2F7")]
	[Address(RVA = "0x1BCF6BC", Offset = "0x1BCF6BC", VA = "0x1BCF6BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B2F8")]
	[Address(RVA = "0x1BCF6C4", Offset = "0x1BCF6C4", VA = "0x1BCF6C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600B2F9")]
	[Address(RVA = "0x1BCF6CC", Offset = "0x1BCF6CC", VA = "0x1BCF6CC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
