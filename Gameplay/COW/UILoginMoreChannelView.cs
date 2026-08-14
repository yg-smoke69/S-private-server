using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003856")]
public class UILoginMoreChannelView : UIBaseView
{
	[Token(Token = "0x4017162")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4017163")]
	[FieldOffset(Offset = "0x18")]
	public UIButton VK;

	[Token(Token = "0x4017164")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Google;

	[Token(Token = "0x4017165")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Facebook;

	[Token(Token = "0x4017166")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Twitter;

	[Token(Token = "0x4017167")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Garena;

	[Token(Token = "0x4017168")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GarenaTips;

	[Token(Token = "0x6016CAD")]
	[Address(RVA = "0x21F495C", Offset = "0x21F495C", VA = "0x21F495C")]
	public UILoginMoreChannelView()
	{
	}

	[Token(Token = "0x6016CAE")]
	[Address(RVA = "0x21F4964", Offset = "0x21F4964", VA = "0x21F4964", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CAF")]
	[Address(RVA = "0x21F4D4C", Offset = "0x21F4D4C", VA = "0x21F4D4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
