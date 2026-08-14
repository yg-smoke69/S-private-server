using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003708")]
public class UIHudReplayCtrlView : UIBaseView
{
	[Token(Token = "0x401638C")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition ContainerTP;

	[Token(Token = "0x401638D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton JumpBtn;

	[Token(Token = "0x401638E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PauseBtn;

	[Token(Token = "0x401638F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton PlayBtn;

	[Token(Token = "0x4016390")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MinusBtn;

	[Token(Token = "0x4016391")]
	[FieldOffset(Offset = "0x28")]
	public UIButton PlusBtn;

	[Token(Token = "0x4016392")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SpeedTxt;

	[Token(Token = "0x4016393")]
	[FieldOffset(Offset = "0x30")]
	public UISprite EventTagTemplate;

	[Token(Token = "0x4016394")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TimeTxt;

	[Token(Token = "0x4016395")]
	[FieldOffset(Offset = "0x38")]
	public UISlider GameTimeSlider;

	[Token(Token = "0x4016396")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ProgressBG;

	[Token(Token = "0x4016397")]
	[FieldOffset(Offset = "0x40")]
	public UISprite BG;

	[Token(Token = "0x4016398")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ExitBtn;

	[Token(Token = "0x4016399")]
	[FieldOffset(Offset = "0x48")]
	public UIButton ToggleBtn;

	[Token(Token = "0x401639A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Normal;

	[Token(Token = "0x401639B")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Highlight;

	[Token(Token = "0x401639C")]
	[FieldOffset(Offset = "0x54")]
	public UIButton HighlightBtn;

	[Token(Token = "0x401639D")]
	[FieldOffset(Offset = "0x58")]
	public UIButton ReplayBtn;

	[Token(Token = "0x401639E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject VFXGO;

	[Token(Token = "0x401639F")]
	[FieldOffset(Offset = "0x60")]
	public Animation VFXAnim;

	[Token(Token = "0x40163A0")]
	[FieldOffset(Offset = "0x64")]
	public UICheckboxButton MusicBtn;

	[Token(Token = "0x40163A1")]
	[FieldOffset(Offset = "0x68")]
	public UIButton OverlooktCamBtn;

	[Token(Token = "0x40163A2")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton NormalCamBtn;

	[Token(Token = "0x40163A3")]
	[FieldOffset(Offset = "0x70")]
	public UIButton NoHighlightBtn;

	[Token(Token = "0x60168C3")]
	[Address(RVA = "0x13E546C", Offset = "0x13E546C", VA = "0x13E546C")]
	public UIHudReplayCtrlView()
	{
	}

	[Token(Token = "0x60168C4")]
	[Address(RVA = "0x13E5474", Offset = "0x13E5474", VA = "0x13E5474", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168C5")]
	[Address(RVA = "0x13E5E98", Offset = "0x13E5E98", VA = "0x13E5E98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
