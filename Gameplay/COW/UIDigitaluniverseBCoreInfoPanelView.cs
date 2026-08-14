using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CB")]
public class UIDigitaluniverseBCoreInfoPanelView : UIBaseView
{
	[Token(Token = "0x4014AFB")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HeadIcon;

	[Token(Token = "0x4014AFC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PlayerName;

	[Token(Token = "0x4014AFD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GravityValue;

	[Token(Token = "0x4014AFE")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ThumbBtn;

	[Token(Token = "0x4014AFF")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ThumbSprite;

	[Token(Token = "0x4014B00")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ThumbLabel;

	[Token(Token = "0x4014B01")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton AddPlayerBtn;

	[Token(Token = "0x4014B02")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SignWord;

	[Token(Token = "0x4014B03")]
	[FieldOffset(Offset = "0x34")]
	public UIButton AssistBtn;

	[Token(Token = "0x4014B04")]
	[FieldOffset(Offset = "0x38")]
	public UILabel assistTimeLabel;

	[Token(Token = "0x4014B05")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel teamGameLabel;

	[Token(Token = "0x4014B06")]
	[FieldOffset(Offset = "0x40")]
	public UIButton MaskBtn;

	[Token(Token = "0x4014B07")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Content;

	[Token(Token = "0x4014B08")]
	[FieldOffset(Offset = "0x48")]
	public GameObject VFX;

	[Token(Token = "0x4014B09")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite AssistBg;

	[Token(Token = "0x4014B0A")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Assisted;

	[Token(Token = "0x4014B0B")]
	[FieldOffset(Offset = "0x54")]
	public Transform RecoverTime;

	[Token(Token = "0x6016215")]
	[Address(RVA = "0x2ADEEC4", Offset = "0x2ADEEC4", VA = "0x2ADEEC4")]
	public UIDigitaluniverseBCoreInfoPanelView()
	{
	}

	[Token(Token = "0x6016216")]
	[Address(RVA = "0x2ADEECC", Offset = "0x2ADEECC", VA = "0x2ADEECC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016217")]
	[Address(RVA = "0x2ADF628", Offset = "0x2ADF628", VA = "0x2ADF628")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
