using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036EB")]
public class UIHudPresetView : UIBaseView
{
	[Token(Token = "0x401630E")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition ShowAnim;

	[Token(Token = "0x401630F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BGBtn;

	[Token(Token = "0x4016310")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4016311")]
	[FieldOffset(Offset = "0x20")]
	public UITable PresetTable;

	[Token(Token = "0x4016312")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup presetToggleBtnGroup;

	[Token(Token = "0x4016313")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CloseBtn;

	[Token(Token = "0x4016314")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteCloseBtnLight;

	[Token(Token = "0x4016315")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LeftTimeShow;

	[Token(Token = "0x4016316")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LeftTime;

	[Token(Token = "0x4016317")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4016318")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel title;

	[Token(Token = "0x4016319")]
	[FieldOffset(Offset = "0x40")]
	public UIButton RefreshBtn;

	[Token(Token = "0x401631A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Refreshtimes;

	[Token(Token = "0x601686C")]
	[Address(RVA = "0x1FC6138", Offset = "0x1FC6138", VA = "0x1FC6138")]
	public UIHudPresetView()
	{
	}

	[Token(Token = "0x601686D")]
	[Address(RVA = "0x1FC6140", Offset = "0x1FC6140", VA = "0x1FC6140", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601686E")]
	[Address(RVA = "0x1FC675C", Offset = "0x1FC675C", VA = "0x1FC675C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
