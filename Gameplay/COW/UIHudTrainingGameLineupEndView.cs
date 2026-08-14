using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377B")]
public class UIHudTrainingGameLineupEndView : UIBaseView
{
	[Token(Token = "0x40167A1")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InviteBox;

	[Token(Token = "0x40167A2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelInfo;

	[Token(Token = "0x40167A3")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x40167A4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CancelLabel;

	[Token(Token = "0x40167A5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LeftTimeLabel;

	[Token(Token = "0x40167A6")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnJoin;

	[Token(Token = "0x40167A7")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel JoinLabel;

	[Token(Token = "0x40167A8")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClose;

	[Token(Token = "0x6016A1C")]
	[Address(RVA = "0x15847DC", Offset = "0x15847DC", VA = "0x15847DC")]
	public UIHudTrainingGameLineupEndView()
	{
	}

	[Token(Token = "0x6016A1D")]
	[Address(RVA = "0x15847E4", Offset = "0x15847E4", VA = "0x15847E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A1E")]
	[Address(RVA = "0x1584C20", Offset = "0x1584C20", VA = "0x1584C20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
