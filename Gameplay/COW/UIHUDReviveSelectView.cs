using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003714")]
public class UIHUDReviveSelectView : UIBaseView
{
	[Token(Token = "0x40163E5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ReviveSingleNode;

	[Token(Token = "0x40163E6")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid NameGrid;

	[Token(Token = "0x40163E7")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton PlayerBtn1;

	[Token(Token = "0x40163E8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Select1;

	[Token(Token = "0x40163E9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Name1;

	[Token(Token = "0x40163EA")]
	[FieldOffset(Offset = "0x28")]
	public UIButton PlayerBtn2;

	[Token(Token = "0x40163EB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Select2;

	[Token(Token = "0x40163EC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Name2;

	[Token(Token = "0x40163ED")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PlayerBtn3;

	[Token(Token = "0x40163EE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Select3;

	[Token(Token = "0x40163EF")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Name3;

	[Token(Token = "0x40163F0")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ReviveAllNode;

	[Token(Token = "0x40163F1")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40163F2")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnCancel;

	[Token(Token = "0x60168E7")]
	[Address(RVA = "0x1687D3C", Offset = "0x1687D3C", VA = "0x1687D3C")]
	public UIHUDReviveSelectView()
	{
	}

	[Token(Token = "0x60168E8")]
	[Address(RVA = "0x1687D44", Offset = "0x1687D44", VA = "0x1687D44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168E9")]
	[Address(RVA = "0x1688390", Offset = "0x1688390", VA = "0x1688390")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
