using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F9")]
public class UIInstallmentMallPurchaseItemView : UIBaseView
{
	[Token(Token = "0x4016BC5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Light;

	[Token(Token = "0x4016BC6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CurrentLight;

	[Token(Token = "0x4016BC7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighLightLine;

	[Token(Token = "0x4016BC8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Lock;

	[Token(Token = "0x4016BC9")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LockLine;

	[Token(Token = "0x4016BCA")]
	[FieldOffset(Offset = "0x28")]
	public UISlider ProgressBar;

	[Token(Token = "0x4016BCB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Days;

	[Token(Token = "0x4016BCC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Term;

	[Token(Token = "0x4016BCD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GemIcon;

	[Token(Token = "0x4016BCE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BG;

	[Token(Token = "0x4016BCF")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PriceLabel;

	[Token(Token = "0x6016B96")]
	[Address(RVA = "0x127FBAC", Offset = "0x127FBAC", VA = "0x127FBAC")]
	public UIInstallmentMallPurchaseItemView()
	{
	}

	[Token(Token = "0x6016B97")]
	[Address(RVA = "0x127FBB4", Offset = "0x127FBB4", VA = "0x127FBB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B98")]
	[Address(RVA = "0x12800C8", Offset = "0x12800C8", VA = "0x12800C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
