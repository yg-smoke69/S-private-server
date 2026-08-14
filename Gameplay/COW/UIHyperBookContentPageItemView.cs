using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037EE")]
public class UIHyperBookContentPageItemView : UIBaseView
{
	[Token(Token = "0x4016B09")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PageProgressGO;

	[Token(Token = "0x4016B0A")]
	[FieldOffset(Offset = "0x18")]
	public UISlider PageProgressSlider;

	[Token(Token = "0x4016B0B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite PageCollectionBG;

	[Token(Token = "0x4016B0C")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView2 PageCollectionItemView;

	[Token(Token = "0x4016B0D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PageIdxLabel;

	[Token(Token = "0x4016B0E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PageSelecedFrameIcon;

	[Token(Token = "0x4016B0F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PageLockedIcon;

	[Token(Token = "0x4016B10")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PageTipsIcon;

	[Token(Token = "0x4016B11")]
	[FieldOffset(Offset = "0x34")]
	public UIButton SelectBtn;

	[Token(Token = "0x4016B12")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ProgressSliderBgVFX;

	[Token(Token = "0x4016B13")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite PageCollectionIcon;

	[Token(Token = "0x6016B75")]
	[Address(RVA = "0x29599BC", Offset = "0x29599BC", VA = "0x29599BC")]
	public UIHyperBookContentPageItemView()
	{
	}

	[Token(Token = "0x6016B76")]
	[Address(RVA = "0x29599C4", Offset = "0x29599C4", VA = "0x29599C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B77")]
	[Address(RVA = "0x2959EF0", Offset = "0x2959EF0", VA = "0x2959EF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
