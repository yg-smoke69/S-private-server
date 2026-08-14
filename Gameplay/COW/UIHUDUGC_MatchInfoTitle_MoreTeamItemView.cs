using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003796")]
public class UIHUDUGC_MatchInfoTitle_MoreTeamItemView : UIBaseView
{
	[Token(Token = "0x401683F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Id;

	[Token(Token = "0x4016840")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x4016841")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Score;

	[Token(Token = "0x4016842")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ScoreNum;

	[Token(Token = "0x4016843")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamColor;

	[Token(Token = "0x4016844")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Racing;

	[Token(Token = "0x4016845")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel FinishNum;

	[Token(Token = "0x4016846")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Self;

	[Token(Token = "0x6016A6D")]
	[Address(RVA = "0x2E1403C", Offset = "0x2E1403C", VA = "0x2E1403C")]
	public UIHUDUGC_MatchInfoTitle_MoreTeamItemView()
	{
	}

	[Token(Token = "0x6016A6E")]
	[Address(RVA = "0x2E14044", Offset = "0x2E14044", VA = "0x2E14044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A6F")]
	[Address(RVA = "0x2E14468", Offset = "0x2E14468", VA = "0x2E14468")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
