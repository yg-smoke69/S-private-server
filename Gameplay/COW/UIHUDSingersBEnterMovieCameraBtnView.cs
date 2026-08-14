using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003748")]
public class UIHUDSingersBEnterMovieCameraBtnView : UIBaseView
{
	[Token(Token = "0x40165B0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton MovieBtn;

	[Token(Token = "0x40165B1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MovieSprite;

	[Token(Token = "0x40165B2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TutorialMovieRoot;

	[Token(Token = "0x40165B3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TipLabel;

	[Token(Token = "0x6016983")]
	[Address(RVA = "0x2211490", Offset = "0x2211490", VA = "0x2211490")]
	public UIHUDSingersBEnterMovieCameraBtnView()
	{
	}

	[Token(Token = "0x6016984")]
	[Address(RVA = "0x2211498", Offset = "0x2211498", VA = "0x2211498", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016985")]
	[Address(RVA = "0x2211754", Offset = "0x2211754", VA = "0x2211754")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
