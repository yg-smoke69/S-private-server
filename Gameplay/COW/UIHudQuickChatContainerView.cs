using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F3")]
public class UIHudQuickChatContainerView : UIBaseView
{
	[Token(Token = "0x401632D")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401632E")]
	[FieldOffset(Offset = "0x18")]
	public UITable MessageListTable;

	[Token(Token = "0x401632F")]
	[FieldOffset(Offset = "0x1C")]
	public QuickChatView ChatMessageInstance;

	[Token(Token = "0x4016330")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ListBG;

	[Token(Token = "0x4016331")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ThumbTimesNode;

	[Token(Token = "0x4016332")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalThumbTimes;

	[Token(Token = "0x4016333")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MaxThumbTimes;

	[Token(Token = "0x4016334")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ThumbTimes;

	[Token(Token = "0x6016884")]
	[Address(RVA = "0x1FCA224", Offset = "0x1FCA224", VA = "0x1FCA224")]
	public UIHudQuickChatContainerView()
	{
	}

	[Token(Token = "0x6016885")]
	[Address(RVA = "0x1FCA22C", Offset = "0x1FCA22C", VA = "0x1FCA22C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016886")]
	[Address(RVA = "0x1FCA650", Offset = "0x1FCA650", VA = "0x1FCA650")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
