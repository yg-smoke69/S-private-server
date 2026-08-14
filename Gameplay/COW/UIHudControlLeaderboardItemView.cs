using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003615")]
public class UIHudControlLeaderboardItemView : UIBaseView
{
	[Token(Token = "0x4015A3C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGDefault;

	[Token(Token = "0x4015A3D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGLocal;

	[Token(Token = "0x4015A3E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelName;

	[Token(Token = "0x4015A3F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelClan;

	[Token(Token = "0x4015A40")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Label_1;

	[Token(Token = "0x4015A41")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Label_2;

	[Token(Token = "0x4015A42")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Label_3;

	[Token(Token = "0x4015A43")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RankSprite;

	[Token(Token = "0x60165EE")]
	[Address(RVA = "0x13624D4", Offset = "0x13624D4", VA = "0x13624D4")]
	public UIHudControlLeaderboardItemView()
	{
	}

	[Token(Token = "0x60165EF")]
	[Address(RVA = "0x13624DC", Offset = "0x13624DC", VA = "0x13624DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165F0")]
	[Address(RVA = "0x136290C", Offset = "0x136290C", VA = "0x136290C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
