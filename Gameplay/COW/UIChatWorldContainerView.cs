using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003439")]
public class UIChatWorldContainerView : UIBaseView
{
	[Token(Token = "0x401438E")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x401438F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x4014390")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MessageList;

	[Token(Token = "0x4014391")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LiftTopMessage;

	[Token(Token = "0x4014392")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel LiftTopMessageClipPanel;

	[Token(Token = "0x4014393")]
	[FieldOffset(Offset = "0x28")]
	public BaseChatMessageView LiftTopMessageContent;

	[Token(Token = "0x4014394")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EmptyNode;

	[Token(Token = "0x4014395")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NoMessageHint;

	[Token(Token = "0x601605F")]
	[Address(RVA = "0x2088868", Offset = "0x2088868", VA = "0x2088868")]
	public UIChatWorldContainerView()
	{
	}

	[Token(Token = "0x6016060")]
	[Address(RVA = "0x2088870", Offset = "0x2088870", VA = "0x2088870", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016061")]
	[Address(RVA = "0x2088C88", Offset = "0x2088C88", VA = "0x2088C88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
