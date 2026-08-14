using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DC3")]
public class CollectionBookStoreShowDataManager : SingletonModule<CollectionBookStoreShowDataManager>
{
	[Token(Token = "0x4011909")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, CollectionBookStoreShowData> m_dictIdToBookData;

	[Token(Token = "0x6013306")]
	[Address(RVA = "0x172FD74", Offset = "0x172FD74", VA = "0x172FD74")]
	public CollectionBookStoreShowDataManager()
	{
	}

	[Token(Token = "0x6013307")]
	[Address(RVA = "0x172FE38", Offset = "0x172FE38", VA = "0x172FE38", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013308")]
	[Address(RVA = "0x172FEF8", Offset = "0x172FEF8", VA = "0x172FEF8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013309")]
	[Address(RVA = "0x1730020", Offset = "0x1730020", VA = "0x1730020")]
	public CollectionBookStoreShowData GetDataByBOOKID(uint bookID)
	{
		return null;
	}
}
