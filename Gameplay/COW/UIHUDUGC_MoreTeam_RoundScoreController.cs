using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002459")]
internal class UIHUDUGC_MoreTeam_RoundScoreController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E1D6")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_MoreTeam_RoundScoreView m_View;

	[Token(Token = "0x400E1D7")]
	[FieldOffset(Offset = "0x2C")]
	private TeamRoundScoreBannerHudEntity m_ViewData;

	[Token(Token = "0x400E1D8")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CE9C")]
	[Address(RVA = "0x2E1A518", Offset = "0x2E1A518", VA = "0x2E1A518")]
	public UIHUDUGC_MoreTeam_RoundScoreController()
	{
	}

	[Token(Token = "0x600CE9D")]
	[Address(RVA = "0x2E1A59C", Offset = "0x2E1A59C", VA = "0x2E1A59C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE9E")]
	[Address(RVA = "0x2E1A640", Offset = "0x2E1A640", VA = "0x2E1A640", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE9F")]
	[Address(RVA = "0x2E1A6FC", Offset = "0x2E1A6FC", VA = "0x2E1A6FC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CEA0")]
	[Address(RVA = "0x2E1A7DC", Offset = "0x2E1A7DC", VA = "0x2E1A7DC", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CEA1")]
	[Address(RVA = "0x2E1A768", Offset = "0x2E1A768", VA = "0x2E1A768", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CEA2")]
	[Address(RVA = "0x2E1AB80", Offset = "0x2E1AB80", VA = "0x2E1AB80")]
	private string GetLocText(string key, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600CEA3")]
	[Address(RVA = "0x2E1AE18", Offset = "0x2E1AE18", VA = "0x2E1AE18")]
	private void ShowFirstScore()
	{
	}

	[Token(Token = "0x600CEA4")]
	[Address(RVA = "0x2E1AF60", Offset = "0x2E1AF60", VA = "0x2E1AF60")]
	private void ShowSecondScore()
	{
	}

	[Token(Token = "0x600CEA5")]
	[Address(RVA = "0x2E1B0A8", Offset = "0x2E1B0A8", VA = "0x2E1B0A8")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CEA6")]
	[Address(RVA = "0x2E1B130", Offset = "0x2E1B130", VA = "0x2E1B130")]
	private void OnLocSwitchChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CEA7")]
	[Address(RVA = "0x2E1B218", Offset = "0x2E1B218", VA = "0x2E1B218")]
	private void OnFirstScoreTitleChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CEA8")]
	[Address(RVA = "0x2E1B448", Offset = "0x2E1B448", VA = "0x2E1B448")]
	private void OnFirstScoreValueKeyChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CEA9")]
	[Address(RVA = "0x2E1B4C8", Offset = "0x2E1B4C8", VA = "0x2E1B4C8")]
	private void OnFirstScoreValueParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CEAA")]
	[Address(RVA = "0x2E1B330", Offset = "0x2E1B330", VA = "0x2E1B330")]
	private void OnSecondScoreTitleChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CEAB")]
	[Address(RVA = "0x2E1B548", Offset = "0x2E1B548", VA = "0x2E1B548")]
	private void OnSecondScoreValueKeyChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CEAC")]
	[Address(RVA = "0x2E1B5C8", Offset = "0x2E1B5C8", VA = "0x2E1B5C8")]
	private void OnSecondScoreValueParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CEAD")]
	[Address(RVA = "0x2E1B648", Offset = "0x2E1B648", VA = "0x2E1B648")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CEAE")]
	[Address(RVA = "0x2E1B650", Offset = "0x2E1B650", VA = "0x2E1B650")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
