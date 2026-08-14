using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A6")]
public class UIHUDUGC_RoundScoreBannerView : UIBaseView
{
	[Token(Token = "0x4016892")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RoundNum;

	[Token(Token = "0x4016893")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x4016894")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftDefaultTeamIcon;

	[Token(Token = "0x4016895")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LeftDefaultTeamName;

	[Token(Token = "0x4016896")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RightTeamScore;

	[Token(Token = "0x4016897")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RightDefaultTeamIcon;

	[Token(Token = "0x4016898")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RightDefaultTeamName;

	[Token(Token = "0x6016A9D")]
	[Address(RVA = "0x2E264A0", Offset = "0x2E264A0", VA = "0x2E264A0")]
	public UIHUDUGC_RoundScoreBannerView()
	{
	}

	[Token(Token = "0x6016A9E")]
	[Address(RVA = "0x2E264A8", Offset = "0x2E264A8", VA = "0x2E264A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A9F")]
	[Address(RVA = "0x2E26860", Offset = "0x2E26860", VA = "0x2E26860")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
