using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A7E")]
public class UIWebVideoWindowView : UIBaseView
{
	[Token(Token = "0x4018D9B")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNBg;

	[Token(Token = "0x4018D9C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite VideoView;

	[Token(Token = "0x4018D9D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x6017320")]
	[Address(RVA = "0x1B7DAEC", Offset = "0x1B7DAEC", VA = "0x1B7DAEC")]
	public UIWebVideoWindowView()
	{
	}

	[Token(Token = "0x6017321")]
	[Address(RVA = "0x1B7DAF4", Offset = "0x1B7DAF4", VA = "0x1B7DAF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017322")]
	[Address(RVA = "0x1B7DD5C", Offset = "0x1B7DD5C", VA = "0x1B7DD5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
