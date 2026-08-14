using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002178")]
internal class UIProfileMiniRankInfoController : UIBaseController
{
	[Token(Token = "0x400D217")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileMiniRankInfoView m_View;

	[Token(Token = "0x400D218")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPeriodicLadderMatch m_Model;

	[Token(Token = "0x400D219")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_CSStarArray;

	[Token(Token = "0x400D21A")]
	[FieldOffset(Offset = "0x34")]
	private GameObject[] m_CSBlackStarArray;

	[Token(Token = "0x600B162")]
	[Address(RVA = "0x16EA018", Offset = "0x16EA018", VA = "0x16EA018")]
	public UIProfileMiniRankInfoController()
	{
	}

	[Token(Token = "0x600B163")]
	[Address(RVA = "0x16EA09C", Offset = "0x16EA09C", VA = "0x16EA09C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B164")]
	[Address(RVA = "0x16EA144", Offset = "0x16EA144", VA = "0x16EA144", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B165")]
	[Address(RVA = "0x16EA6E0", Offset = "0x16EA6E0", VA = "0x16EA6E0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B166")]
	[Address(RVA = "0x16EA744", Offset = "0x16EA744", VA = "0x16EA744", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B167")]
	[Address(RVA = "0x16EA7A8", Offset = "0x16EA7A8", VA = "0x16EA7A8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B168")]
	[Address(RVA = "0x16E172C", Offset = "0x16E172C", VA = "0x16E172C")]
	public void SetViewData(CSPlayerPeriodicRankingInfoRes info)
	{
	}

	[Token(Token = "0x600B169")]
	[Address(RVA = "0x16EA80C", Offset = "0x16EA80C", VA = "0x16EA80C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B16A")]
	[Address(RVA = "0x16EA814", Offset = "0x16EA814", VA = "0x16EA814")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B16B")]
	[Address(RVA = "0x16EA81C", Offset = "0x16EA81C", VA = "0x16EA81C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B16C")]
	[Address(RVA = "0x16EA824", Offset = "0x16EA824", VA = "0x16EA824")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
