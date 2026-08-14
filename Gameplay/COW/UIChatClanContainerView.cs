using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200342C")]
public class UIChatClanContainerView : UIBaseView
{
	[Token(Token = "0x40142D8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x40142D9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x40142DA")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MessageList;

	[Token(Token = "0x40142DB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LuckyBagMessage;

	[Token(Token = "0x40142DC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LuckyBagLabel;

	[Token(Token = "0x40142DD")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GoToLuckyBagBtn;

	[Token(Token = "0x40142DE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EmptyNode;

	[Token(Token = "0x40142DF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NoMessageHint;

	[Token(Token = "0x40142E0")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NoClanHint;

	[Token(Token = "0x40142E1")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GotoSearchClanBtn;

	[Token(Token = "0x6016038")]
	[Address(RVA = "0x262DCD0", Offset = "0x262DCD0", VA = "0x262DCD0")]
	public UIChatClanContainerView()
	{
	}

	[Token(Token = "0x6016039")]
	[Address(RVA = "0x262DCD8", Offset = "0x262DCD8", VA = "0x262DCD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601603A")]
	[Address(RVA = "0x262E1A4", Offset = "0x262E1A4", VA = "0x262E1A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
