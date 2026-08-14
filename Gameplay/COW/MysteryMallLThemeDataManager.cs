using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001B5")]
public class MysteryMallLThemeDataManager : SingletonModule<MysteryMallLThemeDataManager>
{
	[Token(Token = "0x20001B6")]
	private sealed class _003CGetThemeData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x8")]
		internal int themeType;

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2291ECC", Offset = "0x2291ECC", VA = "0x2291ECC")]
		public _003CGetThemeData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2291ED4", Offset = "0x2291ED4", VA = "0x2291ED4")]
		internal bool _003C_003Em__0(MysteryMallLuckyDrawThemeData value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0xC")]
	private List<MysteryMallLuckyDrawThemeData> m_ThemeDataList;

	[Token(Token = "0x600094D")]
	[Address(RVA = "0x2291AE0", Offset = "0x2291AE0", VA = "0x2291AE0")]
	public MysteryMallLThemeDataManager()
	{
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x2291B70", Offset = "0x2291B70", VA = "0x2291B70", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x2291C30", Offset = "0x2291C30", VA = "0x2291C30", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x2291D54", Offset = "0x2291D54", VA = "0x2291D54")]
	public MysteryMallLuckyDrawThemeData GetThemeData(int themeType)
	{
		return null;
	}
}
