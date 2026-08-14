using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F4")]
public class UIDownloadCentreTabItemView : UIBaseView
{
	[Token(Token = "0x4014D31")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleLabel;

	[Token(Token = "0x4014D32")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014D33")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RewardBtn;

	[Token(Token = "0x4014D34")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RewardEffect;

	[Token(Token = "0x4014D35")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4014D36")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ProgressBar;

	[Token(Token = "0x4014D37")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4014D38")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RetryBtn;

	[Token(Token = "0x4014D39")]
	[FieldOffset(Offset = "0x34")]
	public UILabel FinishedLabel;

	[Token(Token = "0x4014D3A")]
	[FieldOffset(Offset = "0x38")]
	public UIButton InpendingBtn;

	[Token(Token = "0x4014D3B")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton TabBtn;

	[Token(Token = "0x4014D3C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Select;

	[Token(Token = "0x4014D3D")]
	[FieldOffset(Offset = "0x44")]
	public UIButton PauseBtn;

	[Token(Token = "0x4014D3E")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Hourglass_Rotation;

	[Token(Token = "0x4014D3F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject InPendingEffect;

	[Token(Token = "0x601628C")]
	[Address(RVA = "0x2768E78", Offset = "0x2768E78", VA = "0x2768E78")]
	public UIDownloadCentreTabItemView()
	{
	}

	[Token(Token = "0x601628D")]
	[Address(RVA = "0x2768E80", Offset = "0x2768E80", VA = "0x2768E80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601628E")]
	[Address(RVA = "0x2769544", Offset = "0x2769544", VA = "0x2769544")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
