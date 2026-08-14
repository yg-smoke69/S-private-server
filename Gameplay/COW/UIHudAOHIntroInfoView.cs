using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C9")]
public class UIHudAOHIntroInfoView : UIBaseView
{
	[Token(Token = "0x4015898")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IntroKey;

	[Token(Token = "0x4015899")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IntroDetail;

	[Token(Token = "0x6016509")]
	[Address(RVA = "0x163AF48", Offset = "0x163AF48", VA = "0x163AF48")]
	public UIHudAOHIntroInfoView()
	{
	}

	[Token(Token = "0x601650A")]
	[Address(RVA = "0x163AF50", Offset = "0x163AF50", VA = "0x163AF50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601650B")]
	[Address(RVA = "0x163B0B8", Offset = "0x163B0B8", VA = "0x163B0B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
