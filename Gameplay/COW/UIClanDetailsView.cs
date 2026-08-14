using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200344A")]
public class UIClanDetailsView : UIBaseView
{
	[Token(Token = "0x4014449")]
	[FieldOffset(Offset = "0x14")]
	public UILabel NameLabel;

	[Token(Token = "0x401444A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IDLabel;

	[Token(Token = "0x401444B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite GuildIcon;

	[Token(Token = "0x401444C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GloryLabel;

	[Token(Token = "0x401444D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TAGLabel;

	[Token(Token = "0x401444E")]
	[FieldOffset(Offset = "0x28")]
	public UITable TableContent;

	[Token(Token = "0x401444F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject AreaContainer;

	[Token(Token = "0x4014450")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AreaLabel;

	[Token(Token = "0x4014451")]
	[FieldOffset(Offset = "0x34")]
	public Transform GuildLeaderContent;

	[Token(Token = "0x6016092")]
	[Address(RVA = "0x2F34BC0", Offset = "0x2F34BC0", VA = "0x2F34BC0")]
	public UIClanDetailsView()
	{
	}

	[Token(Token = "0x6016093")]
	[Address(RVA = "0x2F34BC8", Offset = "0x2F34BC8", VA = "0x2F34BC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016094")]
	[Address(RVA = "0x2F3503C", Offset = "0x2F3503C", VA = "0x2F3503C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
