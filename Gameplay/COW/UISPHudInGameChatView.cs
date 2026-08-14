using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C0")]
public class UISPHudInGameChatView : UIBaseView
{
	[Token(Token = "0x4018456")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ChatContainer;

	[Token(Token = "0x4018457")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ChatPanelContainerBg;

	[Token(Token = "0x4018458")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ChatPanel;

	[Token(Token = "0x4018459")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ChatItemTemplate;

	[Token(Token = "0x401845A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseBtn;

	[Token(Token = "0x401845B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoChatLabel;

	[Token(Token = "0x401845C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InputFiledContainer;

	[Token(Token = "0x401845D")]
	[FieldOffset(Offset = "0x30")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x401845E")]
	[FieldOffset(Offset = "0x34")]
	public UIInput InputFiled;

	[Token(Token = "0x401845F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel InputLabel;

	[Token(Token = "0x60170E7")]
	[Address(RVA = "0x1D1E730", Offset = "0x1D1E730", VA = "0x1D1E730")]
	public UISPHudInGameChatView()
	{
	}

	[Token(Token = "0x60170E8")]
	[Address(RVA = "0x1D1E738", Offset = "0x1D1E738", VA = "0x1D1E738", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170E9")]
	[Address(RVA = "0x1D1EB20", Offset = "0x1D1EB20", VA = "0x1D1EB20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
