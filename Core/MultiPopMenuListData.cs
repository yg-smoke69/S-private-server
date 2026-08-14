using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20029CF")]
public class MultiPopMenuListData
{
	[Token(Token = "0x4010120")]
	[FieldOffset(Offset = "0x8")]
	public string m_Key;

	[Token(Token = "0x4010121")]
	[FieldOffset(Offset = "0xC")]
	public string m_Label;

	[Token(Token = "0x4010122")]
	[FieldOffset(Offset = "0x10")]
	public List<int> m_ParentMenuIndex;

	[Token(Token = "0x6010D21")]
	[Address(RVA = "0x1C726E4", Offset = "0x1C726E4", VA = "0x1C726E4")]
	public MultiPopMenuListData()
	{
	}

	[Token(Token = "0x6010D22")]
	[Address(RVA = "0x1C726EC", Offset = "0x1C726EC", VA = "0x1C726EC")]
	public int GetParentMenuIndexCount()
	{
		return default(int);
	}
}
