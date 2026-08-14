using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E41")]
public class GachaPackageInfoData : GachaInfoDataBase
{
	[Token(Token = "0x6013587")]
	[Address(RVA = "0x1052CEC", Offset = "0x1052CEC", VA = "0x1052CEC")]
	public GachaPackageInfoData()
	{
	}

	[Token(Token = "0x6013588")]
	[Address(RVA = "0x10550B8", Offset = "0x10550B8", VA = "0x10550B8")]
	public void ProcessDescData(GachaDesc gachaRes)
	{
	}

	[Token(Token = "0x6013589")]
	[Address(RVA = "0x1053ADC", Offset = "0x1053ADC", VA = "0x1053ADC", Slot = "7")]
	protected virtual void OnProcseeDescData(GachaDesc gachaRes)
	{
	}
}
