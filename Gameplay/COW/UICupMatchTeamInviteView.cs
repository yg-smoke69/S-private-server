using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A5")]
public class UICupMatchTeamInviteView : UIBaseView
{
	[Token(Token = "0x40148C9")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList EasyList;

	[Token(Token = "0x40148CA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EmptyTips;

	[Token(Token = "0x40148CB")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput SearchInput;

	[Token(Token = "0x40148CC")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Search;

	[Token(Token = "0x40148CD")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Reset;

	[Token(Token = "0x60161A3")]
	[Address(RVA = "0x2ABFA94", Offset = "0x2ABFA94", VA = "0x2ABFA94")]
	public UICupMatchTeamInviteView()
	{
	}

	[Token(Token = "0x60161A4")]
	[Address(RVA = "0x2ABFA9C", Offset = "0x2ABFA9C", VA = "0x2ABFA9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161A5")]
	[Address(RVA = "0x2ABFDB8", Offset = "0x2ABFDB8", VA = "0x2ABFDB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
