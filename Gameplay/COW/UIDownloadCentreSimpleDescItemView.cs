using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F2")]
public class UIDownloadCentreSimpleDescItemView : UIBaseView
{
	[Token(Token = "0x4014D10")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4014D11")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4014D12")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RewardBtn;

	[Token(Token = "0x4014D13")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014D14")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardEffect;

	[Token(Token = "0x4014D15")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ProgressBar;

	[Token(Token = "0x4014D16")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4014D17")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DeleteBtn;

	[Token(Token = "0x4014D18")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4014D19")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PauseBtn;

	[Token(Token = "0x4014D1A")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton RetryBtn;

	[Token(Token = "0x4014D1B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FinishedLabel;

	[Token(Token = "0x4014D1C")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Desc;

	[Token(Token = "0x4014D1D")]
	[FieldOffset(Offset = "0x48")]
	public UIButton InPendingBtn;

	[Token(Token = "0x4014D1E")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject InPendingEffect;

	[Token(Token = "0x4014D1F")]
	[FieldOffset(Offset = "0x50")]
	public UISprite TagState;

	[Token(Token = "0x4014D20")]
	[FieldOffset(Offset = "0x54")]
	public UILabel RewardNum;

	[Token(Token = "0x6016286")]
	[Address(RVA = "0x2765B5C", Offset = "0x2765B5C", VA = "0x2765B5C")]
	public UIDownloadCentreSimpleDescItemView()
	{
	}

	[Token(Token = "0x6016287")]
	[Address(RVA = "0x2765B64", Offset = "0x2765B64", VA = "0x2765B64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016288")]
	[Address(RVA = "0x27662E8", Offset = "0x27662E8", VA = "0x27662E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
