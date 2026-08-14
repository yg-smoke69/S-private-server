using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A9")]
public class MetaTemplateConfigManager
{
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x8")]
	private List<MetaTemplateConfigData> dataList;

	[Token(Token = "0x17000144")]
	public List<MetaTemplateConfigData> DataList
	{
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x2276C38", Offset = "0x2276C38", VA = "0x2276C38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0x2276BAC", Offset = "0x2276BAC", VA = "0x2276BAC")]
	public MetaTemplateConfigManager()
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x2276C90", Offset = "0x2276C90", VA = "0x2276C90")]
	public void Load()
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x2276DE0", Offset = "0x2276DE0", VA = "0x2276DE0")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x2276E9C", Offset = "0x2276E9C", VA = "0x2276E9C")]
	public MetaTemplateConfigData GetPrefabConfigData(uint itemID)
	{
		return null;
	}
}
