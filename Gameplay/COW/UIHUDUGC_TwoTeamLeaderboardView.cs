using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B2")]
public class UIHUDUGC_TwoTeamLeaderboardView : UIBaseView
{
	[Token(Token = "0x40168E6")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTeammateInfo;

	[Token(Token = "0x40168E7")]
	[FieldOffset(Offset = "0x18")]
	public Transform RightTeammateInfo;

	[Token(Token = "0x40168E8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x40168E9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RightTeamScore;

	[Token(Token = "0x40168EA")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SpaceBtn;

	[Token(Token = "0x6016AC1")]
	[Address(RVA = "0x2929544", Offset = "0x2929544", VA = "0x2929544")]
	public UIHUDUGC_TwoTeamLeaderboardView()
	{
	}

	[Token(Token = "0x6016AC2")]
	[Address(RVA = "0x292954C", Offset = "0x292954C", VA = "0x292954C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AC3")]
	[Address(RVA = "0x2929824", Offset = "0x2929824", VA = "0x2929824")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
