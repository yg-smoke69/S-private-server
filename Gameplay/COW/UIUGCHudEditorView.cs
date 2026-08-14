using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2D")]
public class UIUGCHudEditorView : UIBaseView
{
	[Token(Token = "0x4018913")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4018914")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Panel;

	[Token(Token = "0x4018915")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Undo;

	[Token(Token = "0x4018916")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Redo;

	[Token(Token = "0x4018917")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Label;

	[Token(Token = "0x4018918")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Image;

	[Token(Token = "0x4018919")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Button;

	[Token(Token = "0x401891A")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Input;

	[Token(Token = "0x401891B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PanelZoomMax;

	[Token(Token = "0x401891C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PanelZoomMin;

	[Token(Token = "0x401891D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PanelZoomRatio;

	[Token(Token = "0x401891E")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PanelZoomRatioLabel;

	[Token(Token = "0x401891F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Y;

	[Token(Token = "0x4018920")]
	[FieldOffset(Offset = "0x48")]
	public UILabel X;

	[Token(Token = "0x4018921")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Width;

	[Token(Token = "0x4018922")]
	[FieldOffset(Offset = "0x50")]
	public UILabel Height;

	[Token(Token = "0x4018923")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Angle;

	[Token(Token = "0x4018924")]
	[FieldOffset(Offset = "0x58")]
	public GameObject TransformInfo;

	[Token(Token = "0x4018925")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton Texture;

	[Token(Token = "0x601722D")]
	[Address(RVA = "0x2FF35C4", Offset = "0x2FF35C4", VA = "0x2FF35C4")]
	public UIUGCHudEditorView()
	{
	}

	[Token(Token = "0x601722E")]
	[Address(RVA = "0x2FF35CC", Offset = "0x2FF35CC", VA = "0x2FF35CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601722F")]
	[Address(RVA = "0x2FF3E04", Offset = "0x2FF3E04", VA = "0x2FF3E04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
