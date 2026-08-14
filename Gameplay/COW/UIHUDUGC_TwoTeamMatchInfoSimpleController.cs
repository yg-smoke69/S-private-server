using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002485")]
public class UIHUDUGC_TwoTeamMatchInfoSimpleController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E282")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TwoTeamMatchInfoSimpleView m_View;

	[Token(Token = "0x400E283")]
	[FieldOffset(Offset = "0x2C")]
	private TwoTeamMatchInfoSimpleHudEntity m_ViewData;

	[Token(Token = "0x400E284")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400E285")]
	[FieldOffset(Offset = "0x34")]
	private Color Blue;

	[Token(Token = "0x400E286")]
	[FieldOffset(Offset = "0x44")]
	private Color Red;

	[Token(Token = "0x600D07D")]
	[Address(RVA = "0x292CC40", Offset = "0x292CC40", VA = "0x292CC40")]
	public UIHUDUGC_TwoTeamMatchInfoSimpleController()
	{
	}

	[Token(Token = "0x600D07E")]
	[Address(RVA = "0x292CD58", Offset = "0x292CD58", VA = "0x292CD58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D07F")]
	[Address(RVA = "0x292CE00", Offset = "0x292CE00", VA = "0x292CE00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D080")]
	[Address(RVA = "0x292CEBC", Offset = "0x292CEBC", VA = "0x292CEBC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D081")]
	[Address(RVA = "0x292CF9C", Offset = "0x292CF9C", VA = "0x292CF9C", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D082")]
	[Address(RVA = "0x292CF28", Offset = "0x292CF28", VA = "0x292CF28", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D083")]
	[Address(RVA = "0x292D2E4", Offset = "0x292D2E4", VA = "0x292D2E4")]
	private void OnClickLeaderboardBtn()
	{
	}

	[Token(Token = "0x600D084")]
	[Address(RVA = "0x292D338", Offset = "0x292D338", VA = "0x292D338")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D085")]
	[Address(RVA = "0x292D494", Offset = "0x292D494", VA = "0x292D494")]
	private void OnLeftTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D086")]
	[Address(RVA = "0x292D558", Offset = "0x292D558", VA = "0x292D558")]
	private void OnRightTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D087")]
	[Address(RVA = "0x292D61C", Offset = "0x292D61C", VA = "0x292D61C")]
	private void OnLeftTeammateAliveCountChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D088")]
	[Address(RVA = "0x292D6E0", Offset = "0x292D6E0", VA = "0x292D6E0")]
	private void OnRightTeammateAliveCountChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D089")]
	[Address(RVA = "0x292D7A4", Offset = "0x292D7A4", VA = "0x292D7A4")]
	private void OnLeftIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D08A")]
	[Address(RVA = "0x292D914", Offset = "0x292D914", VA = "0x292D914")]
	private void OnRightIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D08B")]
	[Address(RVA = "0x292DA84", Offset = "0x292DA84", VA = "0x292DA84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D08C")]
	[Address(RVA = "0x292DA8C", Offset = "0x292DA8C", VA = "0x292DA8C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
