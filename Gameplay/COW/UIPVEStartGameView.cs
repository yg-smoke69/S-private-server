using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003936")]
public class UIPVEStartGameView : UIBaseView
{
	[Token(Token = "0x4017EF9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnBox;

	[Token(Token = "0x4017EFA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BigRewardIcon;

	[Token(Token = "0x4017EFB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel FinishCounts;

	[Token(Token = "0x4017EFC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BoxUnFinished;

	[Token(Token = "0x4017EFD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BoxFinished;

	[Token(Token = "0x4017EFE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BoxRewarded;

	[Token(Token = "0x4017EFF")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnSoloGame;

	[Token(Token = "0x4017F00")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnGroupGame;

	[Token(Token = "0x4017F01")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnClose;

	[Token(Token = "0x4017F02")]
	[FieldOffset(Offset = "0x38")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4017F03")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid RewardList;

	[Token(Token = "0x4017F04")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DailyPorgress;

	[Token(Token = "0x4017F05")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Finished;

	[Token(Token = "0x4017F06")]
	[FieldOffset(Offset = "0x48")]
	public UINetworkTexture Role;

	[Token(Token = "0x6016F49")]
	[Address(RVA = "0x15A9C6C", Offset = "0x15A9C6C", VA = "0x15A9C6C")]
	public UIPVEStartGameView()
	{
	}

	[Token(Token = "0x6016F4A")]
	[Address(RVA = "0x15A9C74", Offset = "0x15A9C74", VA = "0x15A9C74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F4B")]
	[Address(RVA = "0x15AA2CC", Offset = "0x15AA2CC", VA = "0x15AA2CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
