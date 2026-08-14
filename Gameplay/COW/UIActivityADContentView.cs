using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200339F")]
public class UIActivityADContentView : UIBaseView
{
	[Token(Token = "0x4013B29")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel Mask;

	[Token(Token = "0x4013B2A")]
	[FieldOffset(Offset = "0x18")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x4013B2B")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget DragWidget;

	[Token(Token = "0x4013B2C")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013B2D")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture AD;

	[Token(Token = "0x4013B2E")]
	[FieldOffset(Offset = "0x28")]
	public UIEventListener ADMaxEvent;

	[Token(Token = "0x4013B2F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ArrowDown;

	[Token(Token = "0x4013B30")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GoTo;

	[Token(Token = "0x4013B31")]
	[FieldOffset(Offset = "0x34")]
	public Animation ButtonAnimation;

	[Token(Token = "0x4013B32")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Title;

	[Token(Token = "0x4013B33")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GoToRedpoint;

	[Token(Token = "0x6015E93")]
	[Address(RVA = "0x2A03A14", Offset = "0x2A03A14", VA = "0x2A03A14")]
	public UIActivityADContentView()
	{
	}

	[Token(Token = "0x6015E94")]
	[Address(RVA = "0x2A03A1C", Offset = "0x2A03A1C", VA = "0x2A03A1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E95")]
	[Address(RVA = "0x2A03F6C", Offset = "0x2A03F6C", VA = "0x2A03F6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
