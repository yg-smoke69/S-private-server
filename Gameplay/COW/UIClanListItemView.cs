using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200344E")]
public class UIClanListItemView : UIBaseView
{
	[Token(Token = "0x4014499")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ClanLOGO;

	[Token(Token = "0x401449A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LV;

	[Token(Token = "0x401449B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GuildName;

	[Token(Token = "0x401449C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Honor;

	[Token(Token = "0x401449D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Members;

	[Token(Token = "0x401449E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Slogan;

	[Token(Token = "0x401449F")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton JoinBtn;

	[Token(Token = "0x40144A0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton AppliedBtn;

	[Token(Token = "0x40144A1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AuditApproveLabel;

	[Token(Token = "0x40144A2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AutoWithCond;

	[Token(Token = "0x40144A3")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel AuditAutoLabelWithCond;

	[Token(Token = "0x40144A4")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid AutoCondContent;

	[Token(Token = "0x40144A5")]
	[FieldOffset(Offset = "0x44")]
	public UILabel AutoLevel;

	[Token(Token = "0x40144A6")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Rank;

	[Token(Token = "0x40144A7")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite CSRank;

	[Token(Token = "0x40144A8")]
	[FieldOffset(Offset = "0x50")]
	public GameObject AutoWithoutCond;

	[Token(Token = "0x40144A9")]
	[FieldOffset(Offset = "0x54")]
	public GameObject AuditAutoLabel;

	[Token(Token = "0x601609E")]
	[Address(RVA = "0x2B31C38", Offset = "0x2B31C38", VA = "0x2B31C38")]
	public UIClanListItemView()
	{
	}

	[Token(Token = "0x601609F")]
	[Address(RVA = "0x2B31C40", Offset = "0x2B31C40", VA = "0x2B31C40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160A0")]
	[Address(RVA = "0x2B323B8", Offset = "0x2B323B8", VA = "0x2B323B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
