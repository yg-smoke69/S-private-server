using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200360E")]
public class UIHudChatBtnView : UIBaseView
{
	[Token(Token = "0x4015A19")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ChatBtn;

	[Token(Token = "0x4015A1A")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget WidgetContainer;

	[Token(Token = "0x4015A1B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CloseIcon;

	[Token(Token = "0x4015A1C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Icon;

	[Token(Token = "0x4015A1D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Tip;

	[Token(Token = "0x4015A1E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CDProgress;

	[Token(Token = "0x4015A1F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CDMask;

	[Token(Token = "0x4015A20")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget RouletteChatDir;

	[Token(Token = "0x4015A21")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget RouletteChatCon;

	[Token(Token = "0x60165D8")]
	[Address(RVA = "0x135C058", Offset = "0x135C058", VA = "0x135C058")]
	public UIHudChatBtnView()
	{
	}

	[Token(Token = "0x60165D9")]
	[Address(RVA = "0x135C060", Offset = "0x135C060", VA = "0x135C060", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165DA")]
	[Address(RVA = "0x135C4D8", Offset = "0x135C4D8", VA = "0x135C4D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
