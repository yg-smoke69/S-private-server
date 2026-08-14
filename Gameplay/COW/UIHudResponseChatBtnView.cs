using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003711")]
public class UIHudResponseChatBtnView : UIBaseView
{
	[Token(Token = "0x40163DA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ChatBtn;

	[Token(Token = "0x40163DB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CDBlock;

	[Token(Token = "0x40163DC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Icon;

	[Token(Token = "0x60168DE")]
	[Address(RVA = "0x13F3124", Offset = "0x13F3124", VA = "0x13F3124")]
	public UIHudResponseChatBtnView()
	{
	}

	[Token(Token = "0x60168DF")]
	[Address(RVA = "0x13F312C", Offset = "0x13F312C", VA = "0x13F312C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168E0")]
	[Address(RVA = "0x13F3388", Offset = "0x13F3388", VA = "0x13F3388")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
