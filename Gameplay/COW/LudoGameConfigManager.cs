using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000192")]
public class LudoGameConfigManager
{
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x8")]
	private List<LudoGameConfigData> dataList;

	[Token(Token = "0x17000143")]
	public List<LudoGameConfigData> DataList
	{
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1530BFC", Offset = "0x1530BFC", VA = "0x1530BFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x1530B70", Offset = "0x1530B70", VA = "0x1530B70")]
	public LudoGameConfigManager()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x1530C54", Offset = "0x1530C54", VA = "0x1530C54")]
	public void Load()
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x1530DA4", Offset = "0x1530DA4", VA = "0x1530DA4")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x1530E60", Offset = "0x1530E60", VA = "0x1530E60")]
	public LudoGameConfigData GetPrefabConfigData(uint itemID)
	{
		return null;
	}
}
