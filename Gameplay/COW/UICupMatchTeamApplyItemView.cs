using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A2")]
public class UICupMatchTeamApplyItemView : UIBaseView
{
	[Token(Token = "0x40148B0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40148B1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x40148B2")]
	[FieldOffset(Offset = "0x1C")]
	public Transform BaseProfile;

	[Token(Token = "0x40148B3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton View;

	[Token(Token = "0x40148B4")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Reject;

	[Token(Token = "0x40148B5")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Acept;

	[Token(Token = "0x40148B6")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TireLabel;

	[Token(Token = "0x601619A")]
	[Address(RVA = "0x2AB8020", Offset = "0x2AB8020", VA = "0x2AB8020")]
	public UICupMatchTeamApplyItemView()
	{
	}

	[Token(Token = "0x601619B")]
	[Address(RVA = "0x2AB8028", Offset = "0x2AB8028", VA = "0x2AB8028", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601619C")]
	[Address(RVA = "0x2AB83E8", Offset = "0x2AB83E8", VA = "0x2AB83E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
