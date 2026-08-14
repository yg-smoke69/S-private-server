using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000171")]
public class LikesMessageDataManager : SingletonModule<LikesMessageDataManager>
{
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0xC")]
	private List<LikesMessageData> m_DataList;

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xEC1938", Offset = "0xEC1938", VA = "0xEC1938")]
	public LikesMessageDataManager()
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xEC19FC", Offset = "0xEC19FC", VA = "0xEC19FC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0xEC1B20", Offset = "0xEC1B20", VA = "0xEC1B20", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0xEC1BE0", Offset = "0xEC1BE0", VA = "0xEC1BE0")]
	public List<LikesMessageData> Datas()
	{
		return null;
	}
}
