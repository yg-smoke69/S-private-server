using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003534")]
public class UIFFWS03StoreView : UIBaseView
{
	[Token(Token = "0x4015085")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4015086")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TimeLabel;

	[Token(Token = "0x4015087")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnRule;

	[Token(Token = "0x4015088")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt TitleCDN;

	[Token(Token = "0x4015089")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnStore1;

	[Token(Token = "0x401508A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelectStore1;

	[Token(Token = "0x401508B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NormalStore1;

	[Token(Token = "0x401508C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Store1Lock;

	[Token(Token = "0x401508D")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnStore2;

	[Token(Token = "0x401508E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SelectStore2;

	[Token(Token = "0x401508F")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject NormalStore2;

	[Token(Token = "0x4015090")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Store2Lock;

	[Token(Token = "0x4015091")]
	[FieldOffset(Offset = "0x44")]
	public GameObject StorePage;

	[Token(Token = "0x4015092")]
	[FieldOffset(Offset = "0x48")]
	public UICountDownLabel StoreTip;

	[Token(Token = "0x4015093")]
	[FieldOffset(Offset = "0x4C")]
	public Transform TopBtnContainer;

	[Token(Token = "0x4015094")]
	[FieldOffset(Offset = "0x50")]
	public UILabel GroupLabel1;

	[Token(Token = "0x4015095")]
	[FieldOffset(Offset = "0x54")]
	public UILabel GroupLabel2;

	[Token(Token = "0x4015096")]
	[FieldOffset(Offset = "0x58")]
	public UILabel StoreLabel1;

	[Token(Token = "0x4015097")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel StoreLabel2;

	[Token(Token = "0x4015098")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SwitchRedPoint;

	[Token(Token = "0x4015099")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LabelSwitchRedPoint;

	[Token(Token = "0x401509A")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnSwitchRedPoint;

	[Token(Token = "0x401509B")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject RedPointStore1;

	[Token(Token = "0x401509C")]
	[FieldOffset(Offset = "0x70")]
	public GameObject RedPointStore2;

	[Token(Token = "0x401509D")]
	[FieldOffset(Offset = "0x74")]
	public UINetworkTextureExt CDNBG1;

	[Token(Token = "0x401509E")]
	[FieldOffset(Offset = "0x78")]
	public UINetworkTextureExt CDNBG2;

	[Token(Token = "0x601634C")]
	[Address(RVA = "0x1DB30E0", Offset = "0x1DB30E0", VA = "0x1DB30E0")]
	public UIFFWS03StoreView()
	{
	}

	[Token(Token = "0x601634D")]
	[Address(RVA = "0x1DB30E8", Offset = "0x1DB30E8", VA = "0x1DB30E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601634E")]
	[Address(RVA = "0x1DB3B44", Offset = "0x1DB3B44", VA = "0x1DB3B44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
