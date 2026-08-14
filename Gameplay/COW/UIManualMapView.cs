using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003885")]
public class UIManualMapView : UIBaseView
{
	[Token(Token = "0x40174F7")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIManualMap;

	[Token(Token = "0x40174F8")]
	[FieldOffset(Offset = "0x18")]
	public Transform LeftPos;

	[Token(Token = "0x40174F9")]
	[FieldOffset(Offset = "0x1C")]
	public Transform RightPos;

	[Token(Token = "0x40174FA")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LeftArrow;

	[Token(Token = "0x40174FB")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RightArrow;

	[Token(Token = "0x6016D3A")]
	[Address(RVA = "0x2C41324", Offset = "0x2C41324", VA = "0x2C41324")]
	public UIManualMapView()
	{
	}

	[Token(Token = "0x6016D3B")]
	[Address(RVA = "0x2C4132C", Offset = "0x2C4132C", VA = "0x2C4132C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D3C")]
	[Address(RVA = "0x2C41604", Offset = "0x2C41604", VA = "0x2C41604")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
