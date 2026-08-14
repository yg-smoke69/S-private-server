using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E0D")]
internal class PlayerNameOverWriteDataManager : SingletonModule<PlayerNameOverWriteDataManager>
{
	[Token(Token = "0x2002E0E")]
	public class UserNameConfig
	{
		[Token(Token = "0x4011A3C")]
		[FieldOffset(Offset = "0x8")]
		public ulong UserID;

		[Token(Token = "0x4011A3D")]
		[FieldOffset(Offset = "0x10")]
		public string UserNameOverwrite;

		[Token(Token = "0x4011A3E")]
		[FieldOffset(Offset = "0x14")]
		public string Nation;

		[Token(Token = "0x4011A3F")]
		[FieldOffset(Offset = "0x18")]
		public string Color;

		[Token(Token = "0x60134AB")]
		[Address(RVA = "0x1C0AF34", Offset = "0x1C0AF34", VA = "0x1C0AF34")]
		public UserNameConfig()
		{
		}
	}

	[Token(Token = "0x2002E0F")]
	public class TeammateRegionConfig
	{
		[Token(Token = "0x4011A40")]
		[FieldOffset(Offset = "0x8")]
		public int TeamID;

		[Token(Token = "0x4011A41")]
		[FieldOffset(Offset = "0xC")]
		public string TeamRegion;

		[Token(Token = "0x4011A42")]
		[FieldOffset(Offset = "0x10")]
		public string Color;

		[Token(Token = "0x60134AC")]
		[Address(RVA = "0x1C0AF3C", Offset = "0x1C0AF3C", VA = "0x1C0AF3C")]
		public TeammateRegionConfig()
		{
		}
	}

	[Token(Token = "0x2002E10")]
	private sealed class _003CGetTeamRegionByTeamID_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011A43")]
		[FieldOffset(Offset = "0x8")]
		internal int TeamID;

		[Token(Token = "0x60134AD")]
		[Address(RVA = "0x1C0A448", Offset = "0x1C0A448", VA = "0x1C0A448")]
		public _003CGetTeamRegionByTeamID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60134AE")]
		[Address(RVA = "0x1C0B128", Offset = "0x1C0B128", VA = "0x1C0B128")]
		internal bool _003C_003Em__0(TeammateRegionConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E11")]
	private sealed class _003CGetTeamColorByTeamID_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011A44")]
		[FieldOffset(Offset = "0x8")]
		internal int TeamID;

		[Token(Token = "0x60134AF")]
		[Address(RVA = "0x1C0A5B0", Offset = "0x1C0A5B0", VA = "0x1C0A5B0")]
		public _003CGetTeamColorByTeamID_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60134B0")]
		[Address(RVA = "0x1C0B0F0", Offset = "0x1C0B0F0", VA = "0x1C0B0F0")]
		internal bool _003C_003Em__0(TeammateRegionConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E12")]
	private sealed class _003CGetPlayerNewNameById_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011A45")]
		[FieldOffset(Offset = "0x8")]
		internal ulong ID;

		[Token(Token = "0x60134B1")]
		[Address(RVA = "0x1C0A764", Offset = "0x1C0A764", VA = "0x1C0A764")]
		public _003CGetPlayerNewNameById_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60134B2")]
		[Address(RVA = "0x1C0B0B0", Offset = "0x1C0B0B0", VA = "0x1C0B0B0")]
		internal bool _003C_003Em__0(UserNameConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E13")]
	private sealed class _003CGetPlayerNationByID_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011A46")]
		[FieldOffset(Offset = "0x8")]
		internal ulong ID;

		[Token(Token = "0x60134B3")]
		[Address(RVA = "0x1C0A918", Offset = "0x1C0A918", VA = "0x1C0A918")]
		public _003CGetPlayerNationByID_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60134B4")]
		[Address(RVA = "0x1C0B070", Offset = "0x1C0B070", VA = "0x1C0B070")]
		internal bool _003C_003Em__0(UserNameConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E14")]
	private sealed class _003CGetPlayerColorById_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011A47")]
		[FieldOffset(Offset = "0x8")]
		internal ulong ID;

		[Token(Token = "0x60134B5")]
		[Address(RVA = "0x1C0AA9C", Offset = "0x1C0AA9C", VA = "0x1C0AA9C")]
		public _003CGetPlayerColorById_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60134B6")]
		[Address(RVA = "0x1C0B030", Offset = "0x1C0B030", VA = "0x1C0B030")]
		internal bool _003C_003Em__0(UserNameConfig a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011A3A")]
	[FieldOffset(Offset = "0xC")]
	private List<UserNameConfig> m_PlayerNameListConfig;

	[Token(Token = "0x4011A3B")]
	[FieldOffset(Offset = "0x10")]
	private List<TeammateRegionConfig> m_TeamRegionConfigList;

	[Token(Token = "0x60134A2")]
	[Address(RVA = "0x1C0A168", Offset = "0x1C0A168", VA = "0x1C0A168")]
	public PlayerNameOverWriteDataManager()
	{
	}

	[Token(Token = "0x60134A3")]
	[Address(RVA = "0x1C0A260", Offset = "0x1C0A260", VA = "0x1C0A260", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134A4")]
	[Address(RVA = "0x1C0A2B4", Offset = "0x1C0A2B4", VA = "0x1C0A2B4")]
	public string GetTeamRegionByTeamID(int TeamID)
	{
		return null;
	}

	[Token(Token = "0x60134A5")]
	[Address(RVA = "0x1C0A450", Offset = "0x1C0A450", VA = "0x1C0A450")]
	public string GetTeamColorByTeamID(int TeamID)
	{
		return null;
	}

	[Token(Token = "0x60134A6")]
	[Address(RVA = "0x1C0A5B8", Offset = "0x1C0A5B8", VA = "0x1C0A5B8")]
	public string GetPlayerNewNameById(ulong ID)
	{
		return null;
	}

	[Token(Token = "0x60134A7")]
	[Address(RVA = "0x1C0A76C", Offset = "0x1C0A76C", VA = "0x1C0A76C")]
	public string GetPlayerNationByID(ulong ID)
	{
		return null;
	}

	[Token(Token = "0x60134A8")]
	[Address(RVA = "0x1C0A920", Offset = "0x1C0A920", VA = "0x1C0A920")]
	public string GetPlayerColorById(ulong ID)
	{
		return null;
	}

	[Token(Token = "0x60134A9")]
	[Address(RVA = "0x1C0AAA4", Offset = "0x1C0AAA4", VA = "0x1C0AAA4")]
	private void LoadDataFromJsonData(JsonData JObjRoot)
	{
	}

	[Token(Token = "0x60134AA")]
	[Address(RVA = "0x1C0AF44", Offset = "0x1C0AF44", VA = "0x1C0AF44", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
