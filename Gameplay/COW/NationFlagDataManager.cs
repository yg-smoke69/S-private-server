using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DFB")]
public class NationFlagDataManager : SingletonModule<NationFlagDataManager>
{
	[Token(Token = "0x2002DFC")]
	private sealed class _003CGet_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011A03")]
		[FieldOffset(Offset = "0x8")]
		internal string countryOrArea;

		[Token(Token = "0x6013455")]
		[Address(RVA = "0x2293598", Offset = "0x2293598", VA = "0x2293598")]
		public _003CGet_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013456")]
		[Address(RVA = "0x2293910", Offset = "0x2293910", VA = "0x2293910")]
		internal bool _003C_003Em__0(NationFlagData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DFD")]
	private sealed class _003CGetWithDefault_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011A04")]
		[FieldOffset(Offset = "0x8")]
		internal string countryOrArea;

		[Token(Token = "0x6013457")]
		[Address(RVA = "0x22936E4", Offset = "0x22936E4", VA = "0x22936E4")]
		public _003CGetWithDefault_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013458")]
		[Address(RVA = "0x22939B4", Offset = "0x22939B4", VA = "0x22939B4")]
		internal bool _003C_003Em__0(NationFlagData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40119FE")]
	[FieldOffset(Offset = "0xC")]
	private List<NationFlagData> m_datas;

	[Token(Token = "0x40119FF")]
	public const string DEFAULT_FLAG = "A_DEFAULT";

	[Token(Token = "0x4011A00")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<NationFlagData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011A01")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<NationFlagData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011A02")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<NationFlagData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x601344B")]
	[Address(RVA = "0x2292E2C", Offset = "0x2292E2C", VA = "0x2292E2C")]
	public NationFlagDataManager()
	{
	}

	[Token(Token = "0x601344C")]
	[Address(RVA = "0x2292EF0", Offset = "0x2292EF0", VA = "0x2292EF0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601344D")]
	[Address(RVA = "0x2292FB0", Offset = "0x2292FB0", VA = "0x2292FB0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601344E")]
	[Address(RVA = "0x2293240", Offset = "0x2293240", VA = "0x2293240")]
	public List<NationFlagData> Datas()
	{
		return null;
	}

	[Token(Token = "0x601344F")]
	[Address(RVA = "0x2293298", Offset = "0x2293298", VA = "0x2293298")]
	public List<NationFlagData> OpenedDatas()
	{
		return null;
	}

	[Token(Token = "0x6013450")]
	[Address(RVA = "0x22933E0", Offset = "0x22933E0", VA = "0x22933E0")]
	public NationFlagData Get(string countryOrArea)
	{
		return null;
	}

	[Token(Token = "0x6013451")]
	[Address(RVA = "0x22935A0", Offset = "0x22935A0", VA = "0x22935A0")]
	public NationFlagData GetWithDefault(string countryOrArea)
	{
		return null;
	}

	[Token(Token = "0x6013452")]
	[Address(RVA = "0x22936EC", Offset = "0x22936EC", VA = "0x22936EC")]
	private static bool _003COnInit_003Em__0(NationFlagData e)
	{
		return default(bool);
	}

	[Token(Token = "0x6013453")]
	[Address(RVA = "0x229371C", Offset = "0x229371C", VA = "0x229371C")]
	private static int _003COnInit_003Em__1(NationFlagData e, NationFlagData o)
	{
		return default(int);
	}

	[Token(Token = "0x6013454")]
	[Address(RVA = "0x22938EC", Offset = "0x22938EC", VA = "0x22938EC")]
	private static bool _003COpenedDatas_003Em__2(NationFlagData e)
	{
		return default(bool);
	}
}
