using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F3")]
public class UIDownloadCentreSimpleItemView : UIBaseView
{
	[Token(Token = "0x4014D21")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4014D22")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4014D23")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RewardBtn;

	[Token(Token = "0x4014D24")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014D25")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardEffect;

	[Token(Token = "0x4014D26")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ProgressBar;

	[Token(Token = "0x4014D27")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4014D28")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DeleteBtn;

	[Token(Token = "0x4014D29")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4014D2A")]
	[FieldOffset(Offset = "0x38")]
	public UIButton InPendingBtn;

	[Token(Token = "0x4014D2B")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton PauseBtn;

	[Token(Token = "0x4014D2C")]
	[FieldOffset(Offset = "0x40")]
	public UIButton RetryBtn;

	[Token(Token = "0x4014D2D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject FinishedLabel;

	[Token(Token = "0x4014D2E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject InPendingEffect;

	[Token(Token = "0x4014D2F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TagState;

	[Token(Token = "0x4014D30")]
	[FieldOffset(Offset = "0x50")]
	public UILabel RewardNum;

	[Token(Token = "0x6016289")]
	[Address(RVA = "0x2766834", Offset = "0x2766834", VA = "0x2766834")]
	public UIDownloadCentreSimpleItemView()
	{
	}

	[Token(Token = "0x601628A")]
	[Address(RVA = "0x276683C", Offset = "0x276683C", VA = "0x276683C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601628B")]
	[Address(RVA = "0x2766F60", Offset = "0x2766F60", VA = "0x2766F60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
