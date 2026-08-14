using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381E")]
public class UILegendClothVaultPickItemView : UIBaseView
{
	[Token(Token = "0x4016DA0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HaveHad;

	[Token(Token = "0x4016DA1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelTitle;

	[Token(Token = "0x4016DA2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoRedDot;

	[Token(Token = "0x4016DA3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnPick;

	[Token(Token = "0x4016DA4")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture TexturePick;

	[Token(Token = "0x4016DA5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoHaventGet;

	[Token(Token = "0x4016DA6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GoPos;

	[Token(Token = "0x4016DA7")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnGoPos;

	[Token(Token = "0x4016DA8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelGoPos;

	[Token(Token = "0x6016C05")]
	[Address(RVA = "0x2540FC0", Offset = "0x2540FC0", VA = "0x2540FC0")]
	public UILegendClothVaultPickItemView()
	{
	}

	[Token(Token = "0x6016C06")]
	[Address(RVA = "0x2540FC8", Offset = "0x2540FC8", VA = "0x2540FC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C07")]
	[Address(RVA = "0x2541440", Offset = "0x2541440", VA = "0x2541440")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
