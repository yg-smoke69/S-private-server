using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B20")]
public class UIShootingGameRankingItem : MonoBehaviour
{
	[Token(Token = "0x4010895")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Rank;

	[Token(Token = "0x4010896")]
	[FieldOffset(Offset = "0x10")]
	public UILabel PlayerName;

	[Token(Token = "0x4010897")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Score;

	[Token(Token = "0x4010898")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Timelabel;

	[Token(Token = "0x4010899")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x401089A")]
	[FieldOffset(Offset = "0x20")]
	public float CreateTime;

	[Token(Token = "0x6011BC0")]
	[Address(RVA = "0x2053568", Offset = "0x2053568", VA = "0x2053568")]
	public UIShootingGameRankingItem()
	{
	}

	[Token(Token = "0x6011BC1")]
	[Address(RVA = "0x2053570", Offset = "0x2053570", VA = "0x2053570")]
	public void SetData(int rank, string nickName, uint score, float createTime, float delTime, bool needFormatTime)
	{
	}

	[Token(Token = "0x6011BC2")]
	[Address(RVA = "0x205378C", Offset = "0x205378C", VA = "0x205378C")]
	private void FormatTime(uint score)
	{
	}

	[Token(Token = "0x6011BC3")]
	[Address(RVA = "0x2053918", Offset = "0x2053918", VA = "0x2053918")]
	public void SetTimeTxt(float time)
	{
	}
}
