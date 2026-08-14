using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003391")]
public class ProxyInfoView : UIBaseView
{
	[Token(Token = "0x4013AAA")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView Content;

	[Token(Token = "0x4013AAB")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x6015E69")]
	[Address(RVA = "0x196CB60", Offset = "0x196CB60", VA = "0x196CB60")]
	public ProxyInfoView()
	{
	}

	[Token(Token = "0x6015E6A")]
	[Address(RVA = "0x196CB68", Offset = "0x196CB68", VA = "0x196CB68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E6B")]
	[Address(RVA = "0x196CD70", Offset = "0x196CD70", VA = "0x196CD70")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
