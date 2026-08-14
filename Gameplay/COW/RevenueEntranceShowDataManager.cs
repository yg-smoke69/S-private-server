using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E19")]
public class RevenueEntranceShowDataManager : SingletonModule<RevenueEntranceShowDataManager>
{
	[Token(Token = "0x4011A53")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, RevenueEntranceShowData> m_Datas;

	[Token(Token = "0x60134C7")]
	[Address(RVA = "0x24093A0", Offset = "0x24093A0", VA = "0x24093A0")]
	public RevenueEntranceShowDataManager()
	{
	}

	[Token(Token = "0x60134C8")]
	[Address(RVA = "0x2409464", Offset = "0x2409464", VA = "0x2409464", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134C9")]
	[Address(RVA = "0x2409884", Offset = "0x2409884", VA = "0x2409884", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60134CA")]
	[Address(RVA = "0x2409944", Offset = "0x2409944", VA = "0x2409944")]
	public uint GetEntrancePriority(ERevenueEntranceType type)
	{
		return default(uint);
	}
}
