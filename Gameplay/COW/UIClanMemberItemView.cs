using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003454")]
public class UIClanMemberItemView : UIBaseView
{
	[Token(Token = "0x40144E2")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGEven;

	[Token(Token = "0x40144E3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGOdd;

	[Token(Token = "0x40144E4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SelectLine;

	[Token(Token = "0x40144E5")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget ClanItemInfoContainer;

	[Token(Token = "0x40144E6")]
	[FieldOffset(Offset = "0x24")]
	public UILabel HonorPointLabel;

	[Token(Token = "0x40144E7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel StatusLabel;

	[Token(Token = "0x40144E8")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ClanPosition;

	[Token(Token = "0x40144E9")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClanPosition;

	[Token(Token = "0x40144EA")]
	[FieldOffset(Offset = "0x34")]
	public Transform AccountInfoContainer;

	[Token(Token = "0x40144EB")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnShowDetail;

	[Token(Token = "0x40144EC")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnSelect;

	[Token(Token = "0x60160B0")]
	[Address(RVA = "0x2B3D190", Offset = "0x2B3D190", VA = "0x2B3D190")]
	public UIClanMemberItemView()
	{
	}

	[Token(Token = "0x60160B1")]
	[Address(RVA = "0x2B3D198", Offset = "0x2B3D198", VA = "0x2B3D198", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160B2")]
	[Address(RVA = "0x2B3D6C0", Offset = "0x2B3D6C0", VA = "0x2B3D6C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
