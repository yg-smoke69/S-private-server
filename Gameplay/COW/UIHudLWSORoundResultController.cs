using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20021A8")]
internal class UIHudLWSORoundResultController : UIBaseController
{
	[Token(Token = "0x400D2D8")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLWSORoundResultView m_View;

	[Token(Token = "0x400D2D9")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400D2DA")]
	[FieldOffset(Offset = "0x30")]
	private byte m_MyTeamID;

	[Token(Token = "0x400D2DB")]
	[FieldOffset(Offset = "0x31")]
	private bool m_LocalPlayerWin;

	[Token(Token = "0x400D2DC")]
	[FieldOffset(Offset = "0x34")]
	private ANBHLMNFJMP m_Game;

	[Token(Token = "0x400D2DD")]
	[FieldOffset(Offset = "0x38")]
	private List<UISprite> m_MyTeamHP;

	[Token(Token = "0x400D2DE")]
	[FieldOffset(Offset = "0x3C")]
	private List<Animation> m_MyTeamHPAnim;

	[Token(Token = "0x400D2DF")]
	[FieldOffset(Offset = "0x40")]
	private List<UISprite> m_OppoTeamHP;

	[Token(Token = "0x400D2E0")]
	[FieldOffset(Offset = "0x44")]
	private List<Animation> m_OppoTeamHPAnim;

	[Token(Token = "0x400D2E1")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Inited;

	[Token(Token = "0x400D2E2")]
	[FieldOffset(Offset = "0x49")]
	private bool m_LoseTeamIsEliminate;

	[Token(Token = "0x600B2DF")]
	[Address(RVA = "0x1BCB7D0", Offset = "0x1BCB7D0", VA = "0x1BCB7D0")]
	public UIHudLWSORoundResultController()
	{
	}

	[Token(Token = "0x600B2E0")]
	[Address(RVA = "0x1BCB8EC", Offset = "0x1BCB8EC", VA = "0x1BCB8EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B2E1")]
	[Address(RVA = "0x1BCB994", Offset = "0x1BCB994", VA = "0x1BCB994", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B2E2")]
	[Address(RVA = "0x1BCBC0C", Offset = "0x1BCBC0C", VA = "0x1BCBC0C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B2E3")]
	[Address(RVA = "0x1BCC9A4", Offset = "0x1BCC9A4", VA = "0x1BCC9A4")]
	public void SetResultInfo(NJFIKDODFBK res)
	{
	}

	[Token(Token = "0x600B2E4")]
	[Address(RVA = "0x1BCC600", Offset = "0x1BCC600", VA = "0x1BCC600")]
	private void SetTeamInfo()
	{
	}

	[Token(Token = "0x600B2E5")]
	[Address(RVA = "0x1BCCC1C", Offset = "0x1BCCC1C", VA = "0x1BCCC1C")]
	private void SetTeamName(byte teamID, UILabel teamNameLabel)
	{
	}

	[Token(Token = "0x600B2E6")]
	[Address(RVA = "0x1BCCF94", Offset = "0x1BCCF94", VA = "0x1BCCF94")]
	private void SetTeamFactionIcon(UISprite sprite, MHAKBOKLPMP identity, bool isSelf)
	{
	}

	[Token(Token = "0x600B2E7")]
	[Address(RVA = "0x1BCBE24", Offset = "0x1BCBE24", VA = "0x1BCBE24")]
	private void InitTeamHP()
	{
	}

	[Token(Token = "0x600B2E8")]
	[Address(RVA = "0x1BCD0B4", Offset = "0x1BCD0B4", VA = "0x1BCD0B4")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600B2E9")]
	[Address(RVA = "0x1BCD6E4", Offset = "0x1BCD6E4", VA = "0x1BCD6E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B2EA")]
	[Address(RVA = "0x1BCD6EC", Offset = "0x1BCD6EC", VA = "0x1BCD6EC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
