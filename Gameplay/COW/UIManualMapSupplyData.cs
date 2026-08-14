using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E4C")]
public class UIManualMapSupplyData : UIManualDataBase
{
	[Token(Token = "0x4011B1E")]
	[FieldOffset(Offset = "0x38")]
	public List<ManualInMapData> m_InMapDataList;

	[Token(Token = "0x4011B1F")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, ManualInMapData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011B20")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ManualInMapData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60135E6")]
	[Address(RVA = "0x2C2B8C8", Offset = "0x2C2B8C8", VA = "0x2C2B8C8")]
	public UIManualMapSupplyData()
	{
	}

	[Token(Token = "0x60135E7")]
	[Address(RVA = "0x2C3FFD0", Offset = "0x2C3FFD0", VA = "0x2C3FFD0", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60135E8")]
	[Address(RVA = "0x2C40040", Offset = "0x2C40040", VA = "0x2C40040")]
	private void GetInMapData()
	{
	}

	[Token(Token = "0x60135E9")]
	[Address(RVA = "0x2C402C4", Offset = "0x2C402C4", VA = "0x2C402C4")]
	private static ManualInMapData _003CGetInMapData_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x60135EA")]
	[Address(RVA = "0x2C40358", Offset = "0x2C40358", VA = "0x2C40358")]
	private static bool _003CGetInMapData_003Em__1(ManualInMapData e)
	{
		return default(bool);
	}

	[Token(Token = "0x60135EB")]
	[Address(RVA = "0x2C40388", Offset = "0x2C40388", VA = "0x2C40388")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
