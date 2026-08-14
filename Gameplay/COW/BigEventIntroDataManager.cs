using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DAF")]
public class BigEventIntroDataManager : SingletonModule<BigEventIntroDataManager>
{
	[Token(Token = "0x2002DB0")]
	private sealed class _003CGetIntroData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011891")]
		[FieldOffset(Offset = "0x8")]
		internal EBigEventIntroTiming timing;

		[Token(Token = "0x60131FF")]
		[Address(RVA = "0x2E68534", Offset = "0x2E68534", VA = "0x2E68534")]
		public _003CGetIntroData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013200")]
		[Address(RVA = "0x2E6853C", Offset = "0x2E6853C", VA = "0x2E6853C")]
		internal bool _003C_003Em__0(BigEventIntroData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011890")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, List<BigEventIntroData>> m_Data;

	[Token(Token = "0x60131FB")]
	[Address(RVA = "0x2E67EA0", Offset = "0x2E67EA0", VA = "0x2E67EA0")]
	public BigEventIntroDataManager()
	{
	}

	[Token(Token = "0x60131FC")]
	[Address(RVA = "0x2E67F64", Offset = "0x2E67F64", VA = "0x2E67F64", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60131FD")]
	[Address(RVA = "0x2E682D8", Offset = "0x2E682D8", VA = "0x2E682D8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60131FE")]
	[Address(RVA = "0x2E68398", Offset = "0x2E68398", VA = "0x2E68398")]
	public BigEventIntroData GetIntroData(ELimitedEvent.EventID eventId, EBigEventIntroTiming timing)
	{
		return null;
	}
}
