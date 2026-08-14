using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000232")]
public class SingersBItemConfigManager
{
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x8")]
	private List<SingelsBItemConfigData> dataList;

	[Token(Token = "0x1700016B")]
	public List<SingelsBItemConfigData> DataList
	{
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x20EEEFC", Offset = "0x20EEEFC", VA = "0x20EEEFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x20EEE70", Offset = "0x20EEE70", VA = "0x20EEE70")]
	public SingersBItemConfigManager()
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x20EEF54", Offset = "0x20EEF54", VA = "0x20EEF54")]
	public void Load()
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x20EF0A4", Offset = "0x20EF0A4", VA = "0x20EF0A4")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x20EF160", Offset = "0x20EF160", VA = "0x20EF160")]
	public SingelsBItemConfigData GetPrefabConfigData(uint itemID)
	{
		return null;
	}
}
