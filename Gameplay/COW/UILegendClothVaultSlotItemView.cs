using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003820")]
public class UILegendClothVaultSlotItemView : UIBaseView
{
	[Token(Token = "0x4016DAD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnChoose;

	[Token(Token = "0x4016DAE")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteBtnChoose;

	[Token(Token = "0x4016DAF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoWearing;

	[Token(Token = "0x4016DB0")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteSlotIcon;

	[Token(Token = "0x4016DB1")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016DB2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteNoItem;

	[Token(Token = "0x6016C0B")]
	[Address(RVA = "0x2542B00", Offset = "0x2542B00", VA = "0x2542B00")]
	public UILegendClothVaultSlotItemView()
	{
	}

	[Token(Token = "0x6016C0C")]
	[Address(RVA = "0x2542B08", Offset = "0x2542B08", VA = "0x2542B08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C0D")]
	[Address(RVA = "0x2542E84", Offset = "0x2542E84", VA = "0x2542E84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
