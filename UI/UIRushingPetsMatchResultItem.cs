using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20022EF")]
public class UIRushingPetsMatchResultItem : MonoBehaviour
{
	[Token(Token = "0x400DA17")]
	[FieldOffset(Offset = "0xC")]
	public UILabel PlayerName;

	[Token(Token = "0x400DA18")]
	[FieldOffset(Offset = "0x10")]
	public UILabel PlayerRank;

	[Token(Token = "0x400DA19")]
	[FieldOffset(Offset = "0x14")]
	public UILabel PlayerScore;

	[Token(Token = "0x600C0AC")]
	[Address(RVA = "0x2244818", Offset = "0x2244818", VA = "0x2244818")]
	public UIRushingPetsMatchResultItem()
	{
	}

	[Token(Token = "0x600C0AD")]
	[Address(RVA = "0x2244820", Offset = "0x2244820", VA = "0x2244820")]
	public void InitPlayerInfo(string playerName, int rank, int score)
	{
	}
}
