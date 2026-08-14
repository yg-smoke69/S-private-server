using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DE")]
public class UIHUDWereWolvesUsePredictView : UIBaseView
{
	[Token(Token = "0x4016A6A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ShowRoot;

	[Token(Token = "0x4016A6B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton UseBtn;

	[Token(Token = "0x4016A6C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4016A6D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite bg;

	[Token(Token = "0x4016A6E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NoTargetRoot;

	[Token(Token = "0x6016B45")]
	[Address(RVA = "0x1626D34", Offset = "0x1626D34", VA = "0x1626D34")]
	public UIHUDWereWolvesUsePredictView()
	{
	}

	[Token(Token = "0x6016B46")]
	[Address(RVA = "0x1626D3C", Offset = "0x1626D3C", VA = "0x1626D3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B47")]
	[Address(RVA = "0x162704C", Offset = "0x162704C", VA = "0x162704C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
