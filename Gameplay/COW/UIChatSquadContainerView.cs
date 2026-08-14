using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003434")]
public class UIChatSquadContainerView : UIBaseView
{
	[Token(Token = "0x401432A")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x401432B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MessageNode;

	[Token(Token = "0x401432C")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView SquadMessageList;

	[Token(Token = "0x401432D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EmptyNode;

	[Token(Token = "0x401432E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NoMessageHint;

	[Token(Token = "0x401432F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoSquadObjcetHint;

	[Token(Token = "0x4014330")]
	[FieldOffset(Offset = "0x2C")]
	public Transform SquadList;

	[Token(Token = "0x4014331")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4014332")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016050")]
	[Address(RVA = "0x207CFDC", Offset = "0x207CFDC", VA = "0x207CFDC")]
	public UIChatSquadContainerView()
	{
	}

	[Token(Token = "0x6016051")]
	[Address(RVA = "0x207CFE4", Offset = "0x207CFE4", VA = "0x207CFE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016052")]
	[Address(RVA = "0x207D434", Offset = "0x207D434", VA = "0x207D434")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
