using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001C4")]
public class OptionGameConfigManager
{
	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x8")]
	private List<OptionGameConfigData> dataList;

	[Token(Token = "0x17000145")]
	public List<OptionGameConfigData> DataList
	{
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x28C75C0", Offset = "0x28C75C0", VA = "0x28C75C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0x28C7534", Offset = "0x28C7534", VA = "0x28C7534")]
	public OptionGameConfigManager()
	{
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0x28C7618", Offset = "0x28C7618", VA = "0x28C7618")]
	public void Load()
	{
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0x28C7860", Offset = "0x28C7860", VA = "0x28C7860")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6000984")]
	[Address(RVA = "0x28C791C", Offset = "0x28C791C", VA = "0x28C791C")]
	public OptionGameConfigData GetConfigData(uint itemID)
	{
		return null;
	}
}
