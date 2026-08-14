using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000472")]
public class SingersBClothDanceConfigManager
{
	[Token(Token = "0x4003D15")]
	[FieldOffset(Offset = "0x8")]
	private List<SingersBClothDanceConfigData> dataList;

	[Token(Token = "0x4003D16")]
	[FieldOffset(Offset = "0xC")]
	public List<SingersBClothDanceConfigData> defaultDataList;

	[Token(Token = "0x4003D17")]
	[FieldOffset(Offset = "0x10")]
	public List<SingersBClothDanceConfigData> clothdataList;

	[Token(Token = "0x170001F9")]
	public List<SingersBClothDanceConfigData> DataList
	{
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x20EEA88", Offset = "0x20EEA88", VA = "0x20EEA88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600165A")]
	[Address(RVA = "0x20EE9CC", Offset = "0x20EE9CC", VA = "0x20EE9CC")]
	public SingersBClothDanceConfigManager()
	{
	}

	[Token(Token = "0x600165C")]
	[Address(RVA = "0x20EEAE0", Offset = "0x20EEAE0", VA = "0x20EEAE0")]
	public void Load()
	{
	}

	[Token(Token = "0x600165D")]
	[Address(RVA = "0x20EEDB4", Offset = "0x20EEDB4", VA = "0x20EEDB4")]
	public void Cleanup()
	{
	}
}
