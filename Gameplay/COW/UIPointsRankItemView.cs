using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390D")]
public class UIPointsRankItemView : UIBaseView
{
	[Token(Token = "0x4017BC3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itembtn;

	[Token(Token = "0x4017BC4")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4017BC5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Rank;

	[Token(Token = "0x4017BC6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CupIcon;

	[Token(Token = "0x4017BC7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GuildName;

	[Token(Token = "0x4017BC8")]
	[FieldOffset(Offset = "0x28")]
	public UISprite GuildLogo;

	[Token(Token = "0x4017BC9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Level;

	[Token(Token = "0x4017BCA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Points;

	[Token(Token = "0x6016ED0")]
	[Address(RVA = "0x2C54838", Offset = "0x2C54838", VA = "0x2C54838")]
	public UIPointsRankItemView()
	{
	}

	[Token(Token = "0x6016ED1")]
	[Address(RVA = "0x2C54840", Offset = "0x2C54840", VA = "0x2C54840", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ED2")]
	[Address(RVA = "0x2C54C88", Offset = "0x2C54C88", VA = "0x2C54C88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
