using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000EE")]
public class CollectionPrivilegeTagDataManager : SingletonModule<CollectionPrivilegeTagDataManager>
{
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, CollectionPrivilegeTagData> m_CollectionPrivilegeTagDataDic;

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x1737010", Offset = "0x1737010", VA = "0x1737010")]
	public CollectionPrivilegeTagDataManager()
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x17370D4", Offset = "0x17370D4", VA = "0x17370D4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x1737194", Offset = "0x1737194", VA = "0x1737194", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x17373F8", Offset = "0x17373F8", VA = "0x17373F8")]
	public CollectionPrivilegeTagData GetPrivilegeTagDataByType(CollectionPrivilegeTagType type)
	{
		return null;
	}
}
