using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E4A")]
public class UIManualMapDebrisData : UIManualDataBase
{
	[Token(Token = "0x2002E4B")]
	private sealed class _003CCalUnlockMapData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011B1D")]
		[FieldOffset(Offset = "0x8")]
		internal uint it;

		[Token(Token = "0x60135E4")]
		[Address(RVA = "0x2C34570", Offset = "0x2C34570", VA = "0x2C34570")]
		public _003CCalUnlockMapData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60135E5")]
		[Address(RVA = "0x2C346A4", Offset = "0x2C346A4", VA = "0x2C346A4")]
		internal bool _003C_003Em__0(ManualMapData itm)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011B19")]
	[FieldOffset(Offset = "0x38")]
	public List<ManualMapReward> m_MapRewardDataList;

	[Token(Token = "0x4011B1A")]
	[FieldOffset(Offset = "0x3C")]
	public List<ManualMapData> m_UnlockMapDataList;

	[Token(Token = "0x4011B1B")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, ManualMapReward> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011B1C")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, ManualMapData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60135DD")]
	[Address(RVA = "0x2C2B80C", Offset = "0x2C2B80C", VA = "0x2C2B80C")]
	public UIManualMapDebrisData()
	{
	}

	[Token(Token = "0x60135DE")]
	[Address(RVA = "0x2C33E74", Offset = "0x2C33E74", VA = "0x2C33E74", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60135DF")]
	[Address(RVA = "0x2C343AC", Offset = "0x2C343AC", VA = "0x2C343AC")]
	private void LoadManualMapRewardCSV()
	{
	}

	[Token(Token = "0x60135E0")]
	[Address(RVA = "0x2C33EEC", Offset = "0x2C33EEC", VA = "0x2C33EEC")]
	private void CalUnlockMapData()
	{
	}

	[Token(Token = "0x60135E1")]
	[Address(RVA = "0x2C34578", Offset = "0x2C34578", VA = "0x2C34578")]
	private static ManualMapReward _003CLoadManualMapRewardCSV_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x60135E2")]
	[Address(RVA = "0x2C3460C", Offset = "0x2C3460C", VA = "0x2C3460C")]
	private static ManualMapData _003CCalUnlockMapData_003Em__1(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x60135E3")]
	[Address(RVA = "0x2C346A0", Offset = "0x2C346A0", VA = "0x2C346A0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
