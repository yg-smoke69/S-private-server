using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BB")]
public class UIMysteryMallLuckyDrawView : UIBaseView
{
	[Token(Token = "0x401779F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x40177A0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GetLuckContainer;

	[Token(Token = "0x40177A1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnGetLuck;

	[Token(Token = "0x40177A2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelBtnGetLuck;

	[Token(Token = "0x40177A3")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteGetLuck;

	[Token(Token = "0x40177A4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelGetLuckTip;

	[Token(Token = "0x40177A5")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteGetLuckTip;

	[Token(Token = "0x40177A6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FinishLuckContainer;

	[Token(Token = "0x40177A7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelCongratulation;

	[Token(Token = "0x40177A8")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelSuperLuckTip;

	[Token(Token = "0x40177A9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VFXDrawingContainer;

	[Token(Token = "0x40177AA")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Effect_Mask;

	[Token(Token = "0x40177AB")]
	[FieldOffset(Offset = "0x44")]
	public GameObject VFXStopDrawContainer;

	[Token(Token = "0x40177AC")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelLuckNumLBit;

	[Token(Token = "0x40177AD")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelLuckNumRBit;

	[Token(Token = "0x40177AE")]
	[FieldOffset(Offset = "0x50")]
	public GameObject StopDraw_Effect;

	[Token(Token = "0x40177AF")]
	[FieldOffset(Offset = "0x54")]
	public MeshRenderer VFXLuckNum;

	[Token(Token = "0x40177B0")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelLuckBitTip;

	[Token(Token = "0x40177B1")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite LuckNumDefaultBg;

	[Token(Token = "0x40177B2")]
	[FieldOffset(Offset = "0x60")]
	public UISprite LuckNumBg;

	[Token(Token = "0x40177B3")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelLuckBitTip1;

	[Token(Token = "0x40177B4")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnGoMystery;

	[Token(Token = "0x40177B5")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel LabelBtnGoMystery;

	[Token(Token = "0x40177B6")]
	[FieldOffset(Offset = "0x70")]
	public UISprite SpriteGoMystery;

	[Token(Token = "0x40177B7")]
	[FieldOffset(Offset = "0x74")]
	public UINetworkTextureExt CdnBgTexture;

	[Token(Token = "0x40177B8")]
	[FieldOffset(Offset = "0x78")]
	public UIButton ProbabilityTips;

	[Token(Token = "0x6016DDC")]
	[Address(RVA = "0x1B2B9BC", Offset = "0x1B2B9BC", VA = "0x1B2B9BC")]
	public UIMysteryMallLuckyDrawView()
	{
	}

	[Token(Token = "0x6016DDD")]
	[Address(RVA = "0x1B2B9C4", Offset = "0x1B2B9C4", VA = "0x1B2B9C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DDE")]
	[Address(RVA = "0x1B2C484", Offset = "0x1B2C484", VA = "0x1B2C484")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
