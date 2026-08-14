using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2B")]
public class UIUGCHudEditListItemView : UIBaseView
{
	[Token(Token = "0x4018904")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x4018905")]
	[FieldOffset(Offset = "0x18")]
	public Transform Right;

	[Token(Token = "0x4018906")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Selected;

	[Token(Token = "0x4018907")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Default;

	[Token(Token = "0x4018908")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MenuBtn;

	[Token(Token = "0x6017227")]
	[Address(RVA = "0x2FEC8DC", Offset = "0x2FEC8DC", VA = "0x2FEC8DC")]
	public UIUGCHudEditListItemView()
	{
	}

	[Token(Token = "0x6017228")]
	[Address(RVA = "0x2FEC8E4", Offset = "0x2FEC8E4", VA = "0x2FEC8E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017229")]
	[Address(RVA = "0x2FECBCC", Offset = "0x2FECBCC", VA = "0x2FECBCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
