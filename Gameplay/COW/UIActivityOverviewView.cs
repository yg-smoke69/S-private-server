using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AF")]
public class UIActivityOverviewView : UIBaseView
{
	[Token(Token = "0x4013BC7")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Container;

	[Token(Token = "0x4013BC8")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture BGCDN;

	[Token(Token = "0x6015EC3")]
	[Address(RVA = "0x2FBBD98", Offset = "0x2FBBD98", VA = "0x2FBBD98")]
	public UIActivityOverviewView()
	{
	}

	[Token(Token = "0x6015EC4")]
	[Address(RVA = "0x2FBBDA0", Offset = "0x2FBBDA0", VA = "0x2FBBDA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EC5")]
	[Address(RVA = "0x2FBBFA8", Offset = "0x2FBBFA8", VA = "0x2FBBFA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
