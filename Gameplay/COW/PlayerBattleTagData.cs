using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AA3")]
public class PlayerBattleTagData : PlayerTagDataBase
{
	[Token(Token = "0x4010607")]
	[FieldOffset(Offset = "0xC")]
	public uint SubID;

	[Token(Token = "0x4010608")]
	[FieldOffset(Offset = "0x10")]
	public string Title;

	[Token(Token = "0x4010609")]
	[FieldOffset(Offset = "0x14")]
	public string Desc;

	[Token(Token = "0x401060A")]
	[FieldOffset(Offset = "0x0")]
	public static List<int> CdtValues;

	[Token(Token = "0x401060B")]
	[FieldOffset(Offset = "0x18")]
	public int Count;

	[Token(Token = "0x401060C")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsShow;

	[Token(Token = "0x401060D")]
	[FieldOffset(Offset = "0x20")]
	public float equipTimeStamp;

	[Token(Token = "0x60116BF")]
	[Address(RVA = "0x1C07AF4", Offset = "0x1C07AF4", VA = "0x1C07AF4")]
	public PlayerBattleTagData(PlayerBattleTagData data, int index)
	{
	}

	[Token(Token = "0x60116C0")]
	[Address(RVA = "0x1C07B74", Offset = "0x1C07B74", VA = "0x1C07B74")]
	public PlayerBattleTagData()
	{
	}
}
