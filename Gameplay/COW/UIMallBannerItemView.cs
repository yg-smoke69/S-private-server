using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003869")]
public class UIMallBannerItemView : UIBaseView
{
	[Token(Token = "0x40172A0")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x40172A1")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite banner;

	[Token(Token = "0x40172A2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite miniBanner;

	[Token(Token = "0x40172A3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel name;

	[Token(Token = "0x6016CE6")]
	[Address(RVA = "0x23969B8", Offset = "0x23969B8", VA = "0x23969B8")]
	public UIMallBannerItemView()
	{
	}

	[Token(Token = "0x6016CE7")]
	[Address(RVA = "0x23969C0", Offset = "0x23969C0", VA = "0x23969C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CE8")]
	[Address(RVA = "0x2396C88", Offset = "0x2396C88", VA = "0x2396C88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
