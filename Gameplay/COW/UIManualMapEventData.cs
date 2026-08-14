using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E4D")]
public class UIManualMapEventData : UIManualDataBase
{
	[Token(Token = "0x2002E4E")]
	private sealed class _003CGetInMapData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011B24")]
		[FieldOffset(Offset = "0x8")]
		internal EManual.EventType type;

		[Token(Token = "0x60135F1")]
		[Address(RVA = "0x2C39710", Offset = "0x2C39710", VA = "0x2C39710")]
		public _003CGetInMapData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60135F2")]
		[Address(RVA = "0x2C397B0", Offset = "0x2C397B0", VA = "0x2C397B0")]
		internal bool _003C_003Em__0(ManualInMapData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011B21")]
	[FieldOffset(Offset = "0x38")]
	public List<ManualInMapData> m_InMapDataList;

	[Token(Token = "0x4011B22")]
	[FieldOffset(Offset = "0x3C")]
	public float m_IconScale;

	[Token(Token = "0x4011B23")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, ManualInMapData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60135EC")]
	[Address(RVA = "0x2C2B950", Offset = "0x2C2B950", VA = "0x2C2B950")]
	public UIManualMapEventData()
	{
	}

	[Token(Token = "0x60135ED")]
	[Address(RVA = "0x2C39428", Offset = "0x2C39428", VA = "0x2C39428", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60135EE")]
	[Address(RVA = "0x2C394A4", Offset = "0x2C394A4", VA = "0x2C394A4")]
	protected void GetInMapData(EManual.EventType type)
	{
	}

	[Token(Token = "0x60135EF")]
	[Address(RVA = "0x2C39718", Offset = "0x2C39718", VA = "0x2C39718")]
	private static ManualInMapData _003CGetInMapData_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x60135F0")]
	[Address(RVA = "0x2C397AC", Offset = "0x2C397AC", VA = "0x2C397AC")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
