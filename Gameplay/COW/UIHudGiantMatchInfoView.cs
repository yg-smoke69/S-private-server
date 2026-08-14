using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003667")]
public class UIHudGiantMatchInfoView : UIBaseView
{
	[Token(Token = "0x4015D41")]
	[FieldOffset(Offset = "0x14")]
	public Transform myTeam;

	[Token(Token = "0x4015D42")]
	[FieldOffset(Offset = "0x18")]
	public Transform oppoTeam;

	[Token(Token = "0x4015D43")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel myWinNum;

	[Token(Token = "0x4015D44")]
	[FieldOffset(Offset = "0x20")]
	public UILabel remainTime;

	[Token(Token = "0x4015D45")]
	[FieldOffset(Offset = "0x24")]
	public UILabel oppoWinNum;

	[Token(Token = "0x4015D46")]
	[FieldOffset(Offset = "0x28")]
	public UILabel curRound;

	[Token(Token = "0x4015D47")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Team1ShowSpr;

	[Token(Token = "0x4015D48")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Team2ShowSpr;

	[Token(Token = "0x4015D49")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x60166E2")]
	[Address(RVA = "0x1896CB0", Offset = "0x1896CB0", VA = "0x1896CB0")]
	public UIHudGiantMatchInfoView()
	{
	}

	[Token(Token = "0x60166E3")]
	[Address(RVA = "0x1896CB8", Offset = "0x1896CB8", VA = "0x1896CB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166E4")]
	[Address(RVA = "0x1897110", Offset = "0x1897110", VA = "0x1897110")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
