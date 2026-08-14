using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A0")]
public class UICupMatchRewardWndView : UIBaseView
{
	[Token(Token = "0x40148A2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClaimBtn;

	[Token(Token = "0x40148A3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton GotoBtn;

	[Token(Token = "0x40148A4")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40148A5")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CloseBtn;

	[Token(Token = "0x40148A6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Congratulation;

	[Token(Token = "0x40148A7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MatchWin;

	[Token(Token = "0x40148A8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MatchLose;

	[Token(Token = "0x40148A9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LoseToChallenge;

	[Token(Token = "0x40148AA")]
	[FieldOffset(Offset = "0x34")]
	public Transform BoxContainer;

	[Token(Token = "0x6016194")]
	[Address(RVA = "0x2AB57A8", Offset = "0x2AB57A8", VA = "0x2AB57A8")]
	public UICupMatchRewardWndView()
	{
	}

	[Token(Token = "0x6016195")]
	[Address(RVA = "0x2AB57B0", Offset = "0x2AB57B0", VA = "0x2AB57B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016196")]
	[Address(RVA = "0x2AB5C00", Offset = "0x2AB5C00", VA = "0x2AB5C00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
