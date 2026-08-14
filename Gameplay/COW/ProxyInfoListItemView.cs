using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003390")]
public class ProxyInfoListItemView : UIBaseView
{
	[Token(Token = "0x4013AA1")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BlockBtn;

	[Token(Token = "0x4013AA2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel requestLabel;

	[Token(Token = "0x4013AA3")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Content;

	[Token(Token = "0x4013AA4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel message;

	[Token(Token = "0x4013AA5")]
	[FieldOffset(Offset = "0x24")]
	public UIButton timeoutBtn;

	[Token(Token = "0x4013AA6")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TimeOutOffSprite;

	[Token(Token = "0x4013AA7")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TimeOutOnSpirte;

	[Token(Token = "0x4013AA8")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BlockOffSprite;

	[Token(Token = "0x4013AA9")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BlockOnSprite;

	[Token(Token = "0x6015E66")]
	[Address(RVA = "0x196C6A8", Offset = "0x196C6A8", VA = "0x196C6A8")]
	public ProxyInfoListItemView()
	{
	}

	[Token(Token = "0x6015E67")]
	[Address(RVA = "0x196C6B0", Offset = "0x196C6B0", VA = "0x196C6B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E68")]
	[Address(RVA = "0x196CB58", Offset = "0x196CB58", VA = "0x196CB58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
