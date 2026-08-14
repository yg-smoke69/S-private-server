using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003603")]
public class UIHudCannonFireView : UIBaseView
{
	[Token(Token = "0x40159E3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BGFire;

	[Token(Token = "0x40159E4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnFire;

	[Token(Token = "0x40159E5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BtnSprite;

	[Token(Token = "0x60165B7")]
	[Address(RVA = "0x2145F98", Offset = "0x2145F98", VA = "0x2145F98")]
	public UIHudCannonFireView()
	{
	}

	[Token(Token = "0x60165B8")]
	[Address(RVA = "0x2145FA0", Offset = "0x2145FA0", VA = "0x2145FA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165B9")]
	[Address(RVA = "0x2146208", Offset = "0x2146208", VA = "0x2146208")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
