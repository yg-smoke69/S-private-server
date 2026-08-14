using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374C")]
public class UIHudSingleFightLeaderBoardView : UIBaseView
{
	[Token(Token = "0x40165D1")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x40165D2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x40165D3")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x40165D4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TitleInfo4Txt;

	[Token(Token = "0x40165D5")]
	[FieldOffset(Offset = "0x24")]
	public Transform LocalPlayerInfo;

	[Token(Token = "0x40165D6")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BackMask;

	[Token(Token = "0x40165D7")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid PlayerGrid;

	[Token(Token = "0x40165D8")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ReportBtn;

	[Token(Token = "0x601698F")]
	[Address(RVA = "0x16BC404", Offset = "0x16BC404", VA = "0x16BC404")]
	public UIHudSingleFightLeaderBoardView()
	{
	}

	[Token(Token = "0x6016990")]
	[Address(RVA = "0x16BC40C", Offset = "0x16BC40C", VA = "0x16BC40C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016991")]
	[Address(RVA = "0x16BC82C", Offset = "0x16BC82C", VA = "0x16BC82C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
