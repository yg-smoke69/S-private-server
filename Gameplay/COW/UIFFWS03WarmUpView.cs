using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003535")]
public class UIFFWS03WarmUpView : UIBaseView
{
	[Token(Token = "0x401509F")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTextureExt CDNTitle;

	[Token(Token = "0x40150A0")]
	[FieldOffset(Offset = "0x18")]
	public Transform CountDownContainer;

	[Token(Token = "0x40150A1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelFFWSDesc;

	[Token(Token = "0x40150A2")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x40150A3")]
	[FieldOffset(Offset = "0x24")]
	public Animation Anim;

	[Token(Token = "0x601634F")]
	[Address(RVA = "0x1DB4744", Offset = "0x1DB4744", VA = "0x1DB4744")]
	public UIFFWS03WarmUpView()
	{
	}

	[Token(Token = "0x6016350")]
	[Address(RVA = "0x1DB474C", Offset = "0x1DB474C", VA = "0x1DB474C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016351")]
	[Address(RVA = "0x1DB4A4C", Offset = "0x1DB4A4C", VA = "0x1DB4A4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
