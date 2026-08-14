using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D7")]
internal class UISPHudSideMapView : UIBaseView
{
	[Token(Token = "0x4018558")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4018559")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPostion;

	[Token(Token = "0x401855A")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel MapContainer;

	[Token(Token = "0x601712B")]
	[Address(RVA = "0x1D2F99C", Offset = "0x1D2F99C", VA = "0x1D2F99C")]
	public UISPHudSideMapView()
	{
	}

	[Token(Token = "0x601712C")]
	[Address(RVA = "0x1D2F9A4", Offset = "0x1D2F9A4", VA = "0x1D2F9A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601712D")]
	[Address(RVA = "0x1D2FB48", Offset = "0x1D2FB48", VA = "0x1D2FB48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
