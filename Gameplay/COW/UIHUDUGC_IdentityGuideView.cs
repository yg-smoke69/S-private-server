using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003793")]
public class UIHUDUGC_IdentityGuideView : UIBaseView
{
	[Token(Token = "0x4016838")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4016839")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Description;

	[Token(Token = "0x401683A")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition Root;

	[Token(Token = "0x6016A64")]
	[Address(RVA = "0x2E093E8", Offset = "0x2E093E8", VA = "0x2E093E8")]
	public UIHUDUGC_IdentityGuideView()
	{
	}

	[Token(Token = "0x6016A65")]
	[Address(RVA = "0x2E093F0", Offset = "0x2E093F0", VA = "0x2E093F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A66")]
	[Address(RVA = "0x2E09658", Offset = "0x2E09658", VA = "0x2E09658")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
