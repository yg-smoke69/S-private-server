using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CC")]
public class UIDigitaluniverseBCoreView : UIBaseView
{
	[Token(Token = "0x4014B0C")]
	[FieldOffset(Offset = "0x14")]
	public Animation UIDigitaluniverseBCoreAni;

	[Token(Token = "0x4014B0D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CoreBtn;

	[Token(Token = "0x4014B0E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PlayerName;

	[Token(Token = "0x4014B0F")]
	[FieldOffset(Offset = "0x20")]
	public Transform CoreTrans;

	[Token(Token = "0x4014B10")]
	[FieldOffset(Offset = "0x24")]
	public UISprite PressBar;

	[Token(Token = "0x4014B11")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Complete;

	[Token(Token = "0x4014B12")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SelectedVfxContainer;

	[Token(Token = "0x4014B13")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LongPressVfxContainer;

	[Token(Token = "0x4014B14")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LightenBlow;

	[Token(Token = "0x4014B15")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Lighten;

	[Token(Token = "0x4014B16")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Vfx;

	[Token(Token = "0x4014B17")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RedIcon;

	[Token(Token = "0x4014B18")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CoreSprite;

	[Token(Token = "0x4014B19")]
	[FieldOffset(Offset = "0x48")]
	public Transform AnimationCtl;

	[Token(Token = "0x4014B1A")]
	[FieldOffset(Offset = "0x4C")]
	public LineRendererHelper LineConnect;

	[Token(Token = "0x4014B1B")]
	[FieldOffset(Offset = "0x50")]
	public LineRendererHelper LineConnectFlash;

	[Token(Token = "0x4014B1C")]
	[FieldOffset(Offset = "0x54")]
	public GameObject LongPressLine;

	[Token(Token = "0x6016218")]
	[Address(RVA = "0x2ADF630", Offset = "0x2ADF630", VA = "0x2ADF630")]
	public UIDigitaluniverseBCoreView()
	{
	}

	[Token(Token = "0x6016219")]
	[Address(RVA = "0x2ADF638", Offset = "0x2ADF638", VA = "0x2ADF638", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601621A")]
	[Address(RVA = "0x2ADFD30", Offset = "0x2ADFD30", VA = "0x2ADFD30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
