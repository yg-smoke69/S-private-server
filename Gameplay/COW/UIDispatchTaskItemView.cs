using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034EF")]
public class UIDispatchTaskItemView : UIBaseView
{
	[Token(Token = "0x4014CF0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DispatchTaskItemContainer;

	[Token(Token = "0x4014CF1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TaskTitle;

	[Token(Token = "0x4014CF2")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid AwardGrid;

	[Token(Token = "0x4014CF3")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid AvatarGrid;

	[Token(Token = "0x4014CF4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Operation;

	[Token(Token = "0x4014CF5")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnDispatch;

	[Token(Token = "0x4014CF6")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnReceive;

	[Token(Token = "0x4014CF7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelProcessing;

	[Token(Token = "0x4014CF8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ProcessingAnim;

	[Token(Token = "0x4014CF9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject CountDownTimeContainer;

	[Token(Token = "0x601627D")]
	[Address(RVA = "0x275E138", Offset = "0x275E138", VA = "0x275E138")]
	public UIDispatchTaskItemView()
	{
	}

	[Token(Token = "0x601627E")]
	[Address(RVA = "0x275E140", Offset = "0x275E140", VA = "0x275E140", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601627F")]
	[Address(RVA = "0x275E528", Offset = "0x275E528", VA = "0x275E528")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
