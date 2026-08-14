using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369F")]
public class UIHudLWSOBattleInfoItemView : UIBaseView
{
	[Token(Token = "0x4015FA1")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RedBg;

	[Token(Token = "0x4015FA2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BlueBg;

	[Token(Token = "0x4015FA3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject YellowBg;

	[Token(Token = "0x4015FA4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GreenBg;

	[Token(Token = "0x4015FA5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NameLabel1;

	[Token(Token = "0x4015FA6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Result1;

	[Token(Token = "0x4015FA7")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel NameLabel2;

	[Token(Token = "0x4015FA8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Result2;

	[Token(Token = "0x601678A")]
	[Address(RVA = "0x1BBFB74", Offset = "0x1BBFB74", VA = "0x1BBFB74")]
	public UIHudLWSOBattleInfoItemView()
	{
	}

	[Token(Token = "0x601678B")]
	[Address(RVA = "0x1BBFB7C", Offset = "0x1BBFB7C", VA = "0x1BBFB7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601678C")]
	[Address(RVA = "0x1BBFF7C", Offset = "0x1BBFF7C", VA = "0x1BBFF7C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
