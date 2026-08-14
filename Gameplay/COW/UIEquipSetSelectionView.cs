using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003529")]
public class UIEquipSetSelectionView : UIBaseView
{
	[Token(Token = "0x4014FCF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LastTime;

	[Token(Token = "0x4014FD0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject InGameContainer;

	[Token(Token = "0x4014FD1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftTimeShow;

	[Token(Token = "0x4014FD2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTime;

	[Token(Token = "0x4014FD3")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4014FD4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LobbyContainer;

	[Token(Token = "0x4014FD5")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnClose;

	[Token(Token = "0x4014FD6")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid Grid;

	[Token(Token = "0x4014FD7")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LabelNumShow;

	[Token(Token = "0x601632B")]
	[Address(RVA = "0x19DA2F0", Offset = "0x19DA2F0", VA = "0x19DA2F0")]
	public UIEquipSetSelectionView()
	{
	}

	[Token(Token = "0x601632C")]
	[Address(RVA = "0x19DA2F8", Offset = "0x19DA2F8", VA = "0x19DA2F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601632D")]
	[Address(RVA = "0x19DA770", Offset = "0x19DA770", VA = "0x19DA770")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
