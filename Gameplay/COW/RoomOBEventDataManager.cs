using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E34")]
public class RoomOBEventDataManager : SingletonModule<RoomOBEventDataManager>
{
	[Token(Token = "0x4011ABD")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<byte, RoomOBEventData> m_GlobalEventDataDic;

	[Token(Token = "0x4011ABE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<byte, RoomOBEventData> m_LocalEventDataDic;

	[Token(Token = "0x601352F")]
	[Address(RVA = "0x2416A18", Offset = "0x2416A18", VA = "0x2416A18")]
	public RoomOBEventDataManager()
	{
	}

	[Token(Token = "0x6013530")]
	[Address(RVA = "0x2416AF4", Offset = "0x2416AF4", VA = "0x2416AF4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013531")]
	[Address(RVA = "0x2416DAC", Offset = "0x2416DAC", VA = "0x2416DAC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013532")]
	[Address(RVA = "0x2416E98", Offset = "0x2416E98", VA = "0x2416E98")]
	public RoomOBEventData GetOBEventDataByID(byte eID)
	{
		return null;
	}

	[Token(Token = "0x6013533")]
	[Address(RVA = "0x2416FC0", Offset = "0x2416FC0", VA = "0x2416FC0")]
	public RoomOBEventData GetGlobalEventDataByTypeName(string typeName)
	{
		return null;
	}

	[Token(Token = "0x6013534")]
	[Address(RVA = "0x2417220", Offset = "0x2417220", VA = "0x2417220")]
	public Dictionary<byte, RoomOBEventData> GetGlobalObEventDatas()
	{
		return null;
	}

	[Token(Token = "0x6013535")]
	[Address(RVA = "0x2417278", Offset = "0x2417278", VA = "0x2417278")]
	public Dictionary<byte, RoomOBEventData> GetLocalObEventDatas()
	{
		return null;
	}

	[Token(Token = "0x6013536")]
	[Address(RVA = "0x24172D0", Offset = "0x24172D0", VA = "0x24172D0")]
	public int[] GetPollEventCounts()
	{
		return null;
	}

	[Token(Token = "0x6013537")]
	[Address(RVA = "0x24174D0", Offset = "0x24174D0", VA = "0x24174D0")]
	public int[] GetPollDurations()
	{
		return null;
	}
}
