using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003435")]
public class UIChatSquadItemView : UIBaseView
{
	[Token(Token = "0x4014333")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4014334")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Highlight;

	[Token(Token = "0x4014335")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HeadPic;

	[Token(Token = "0x4014336")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Name;

	[Token(Token = "0x4014337")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UnreadTip;

	[Token(Token = "0x6016053")]
	[Address(RVA = "0x207E198", Offset = "0x207E198", VA = "0x207E198")]
	public UIChatSquadItemView()
	{
	}

	[Token(Token = "0x6016054")]
	[Address(RVA = "0x207E1A0", Offset = "0x207E1A0", VA = "0x207E1A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016055")]
	[Address(RVA = "0x207E4B0", Offset = "0x207E4B0", VA = "0x207E4B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
