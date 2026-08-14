using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003406")]
public class UIBroadcastView : UIBaseView
{
	[Token(Token = "0x4014120")]
	[FieldOffset(Offset = "0x14")]
	public Transform Notice;

	[Token(Token = "0x4014121")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RollNoticeBtn;

	[Token(Token = "0x4014122")]
	[FieldOffset(Offset = "0x1C")]
	public RollNoticeView RollMessage;

	[Token(Token = "0x6015FC6")]
	[Address(RVA = "0x1449238", Offset = "0x1449238", VA = "0x1449238")]
	public UIBroadcastView()
	{
	}

	[Token(Token = "0x6015FC7")]
	[Address(RVA = "0x1449240", Offset = "0x1449240", VA = "0x1449240", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FC8")]
	[Address(RVA = "0x1449480", Offset = "0x1449480", VA = "0x1449480")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
