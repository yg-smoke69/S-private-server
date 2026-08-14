using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001AE")]
public class MShopConfigDataManager : SingletonModule<MShopConfigDataManager>
{
	[Token(Token = "0x20001AF")]
	public enum MShopPlatformType
	{
		[Token(Token = "0x4000A68")]
		Default,
		[Token(Token = "0x4000A69")]
		IOS,
		[Token(Token = "0x4000A6A")]
		Android,
		[Token(Token = "0x4000A6B")]
		IOSMAX,
		[Token(Token = "0x4000A6C")]
		AndroidMAX,
		[Token(Token = "0x4000A6D")]
		AndroidThirdParty,
		[Token(Token = "0x4000A6E")]
		HuaWei,
		[Token(Token = "0x4000A6F")]
		Samsung
	}

	[Token(Token = "0x20001B0")]
	private sealed class _003CGetMshopUrl_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x8")]
		internal int serverID;

		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0xC")]
		internal uint productionID;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x15318B8", Offset = "0x15318B8", VA = "0x15318B8")]
		public _003CGetMshopUrl_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x15319E8", Offset = "0x15319E8", VA = "0x15319E8")]
		internal bool _003C_003Em__0(MShopUrlData x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1531A34", Offset = "0x1531A34", VA = "0x1531A34")]
		internal bool _003C_003Em__1(MShopUrlData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000A63")]
	private const int DEFAULTSERVERID = 0;

	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0xC")]
	private List<MShopUrlData> m_Datas;

	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, MShopUrlData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, MShopUrlData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x153107C", Offset = "0x153107C", VA = "0x153107C")]
	public MShopConfigDataManager()
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0x1531140", Offset = "0x1531140", VA = "0x1531140", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0x1531200", Offset = "0x1531200", VA = "0x1531200", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0x15313E4", Offset = "0x15313E4", VA = "0x15313E4")]
	public string GetMshopUrl(bool isProduction, int serverID, MShopPlatformType platformType)
	{
		return null;
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x15318C0", Offset = "0x15318C0", VA = "0x15318C0")]
	private static MShopUrlData _003COnInit_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0x1531954", Offset = "0x1531954", VA = "0x1531954")]
	private static MShopUrlData _003CGetMshopUrl_003Em__1(CSVBaseData temp)
	{
		return null;
	}
}
