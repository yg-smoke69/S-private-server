using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20001D7")]
public class PatchOptionalResManager : SingletonModule<PatchOptionalResManager>
{
	[Token(Token = "0x20001D8")]
	private sealed class _003CGetPatchOptionaShowData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x8")]
		internal uint OptionalReDefId;

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x2DBC6B8", Offset = "0x2DBC6B8", VA = "0x2DBC6B8")]
		public _003CGetPatchOptionaShowData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x2DBC6C0", Offset = "0x2DBC6C0", VA = "0x2DBC6C0")]
		internal bool _003C_003Em__0(PatchOptionalCategoryManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001D9")]
	private sealed class _003CGetTypeName_003Ec__AnonStorey1
	{
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x8")]
		internal uint TypeId;

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x2DBC778", Offset = "0x2DBC778", VA = "0x2DBC778")]
		public _003CGetTypeName_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x2DBC780", Offset = "0x2DBC780", VA = "0x2DBC780")]
		internal bool _003C_003Em__0(PatchOptionalTypeManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001DA")]
	private sealed class _003CIsRecommengTag_003Ec__AnonStorey2
	{
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x8")]
		internal uint tag;

		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0xC")]
		internal PatchOptionalCategoryManagerData show_data;

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x2DBC7F8", Offset = "0x2DBC7F8", VA = "0x2DBC7F8")]
		public _003CIsRecommengTag_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x2DBC800", Offset = "0x2DBC800", VA = "0x2DBC800")]
		internal bool _003C_003Em__0(PatchOptionalCategoryManagerData item)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x2DBC838", Offset = "0x2DBC838", VA = "0x2DBC838")]
		internal bool _003C_003Em__1(PatchOptionalTypeManagerData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001DB")]
	private sealed class _003CGetTypeData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x8")]
		internal uint typeId;

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x2DBC738", Offset = "0x2DBC738", VA = "0x2DBC738")]
		public _003CGetTypeData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x2DBC740", Offset = "0x2DBC740", VA = "0x2DBC740")]
		internal bool _003C_003Em__0(PatchOptionalTypeManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001DC")]
	private sealed class _003CGetResManagerData_003Ec__AnonStorey4
	{
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x8")]
		internal uint OptionalReDefId;

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x2DBC6F8", Offset = "0x2DBC6F8", VA = "0x2DBC6F8")]
		public _003CGetResManagerData_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x2DBC700", Offset = "0x2DBC700", VA = "0x2DBC700")]
		internal bool _003C_003Em__0(PatchOptionalResManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001DD")]
	private sealed class _003CIsRecommendType_003Ec__AnonStorey5
	{
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x2DBC7B8", Offset = "0x2DBC7B8", VA = "0x2DBC7B8")]
		public _003CIsRecommendType_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x2DBC7C0", Offset = "0x2DBC7C0", VA = "0x2DBC7C0")]
		internal bool _003C_003Em__0(PatchOptionalTypeManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001DE")]
	private sealed class _003CProcessPatchOptionalResManagerData_003Ec__AnonStorey6
	{
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x8")]
		internal PatchOptionalResManagerUpdateDesc item;

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x2DBC884", Offset = "0x2DBC884", VA = "0x2DBC884")]
		public _003CProcessPatchOptionalResManagerData_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x2DBC88C", Offset = "0x2DBC88C", VA = "0x2DBC88C")]
		internal bool _003C_003Em__0(PatchOptionalResManagerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0xC")]
	private List<PatchOptionalCategoryManagerData> OptionalCategoryManagerDatas;

	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x10")]
	private List<PatchOptionalTypeManagerData> OptionalTypeManagerDatas;

	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x14")]
	private List<PatchOptionalResManagerData> OptionalResManagerdatas;

	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x18")]
	private OptionalDownloadClientType clientType;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<PatchOptionalTypeManagerData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x28D339C", Offset = "0x28D339C", VA = "0x28D339C")]
	public PatchOptionalResManager()
	{
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x28D3434", Offset = "0x28D3434", VA = "0x28D3434", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x28D349C", Offset = "0x28D349C", VA = "0x28D349C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0x28D370C", Offset = "0x28D370C", VA = "0x28D370C")]
	public List<uint> GetShowOptionalReDefId()
	{
		return null;
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0x28D3B34", Offset = "0x28D3B34", VA = "0x28D3B34")]
	public List<uint> GetNeedDeleteResOptionalReDefIdList()
	{
		return null;
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x28D3E04", Offset = "0x28D3E04", VA = "0x28D3E04")]
	public PatchOptionalCategoryManagerData GetPatchOptionaShowData(uint OptionalReDefId)
	{
		return null;
	}

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x28D3F7C", Offset = "0x28D3F7C", VA = "0x28D3F7C")]
	public string GetTypeName(uint TypeId)
	{
		return null;
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x28D4174", Offset = "0x28D4174", VA = "0x28D4174")]
	public bool IsRecommengTag(uint tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x28D4358", Offset = "0x28D4358", VA = "0x28D4358")]
	public PatchOptionalTypeManagerData GetTypeData(uint typeId)
	{
		return null;
	}

	[Token(Token = "0x60009D5")]
	[Address(RVA = "0x28D44D0", Offset = "0x28D44D0", VA = "0x28D44D0")]
	public List<PatchOptionalTypeManagerData> GetTotalTypeDatas()
	{
		return null;
	}

	[Token(Token = "0x60009D6")]
	[Address(RVA = "0x28D39BC", Offset = "0x28D39BC", VA = "0x28D39BC")]
	public PatchOptionalResManagerData GetResManagerData(uint OptionalReDefId)
	{
		return null;
	}

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0x28D4528", Offset = "0x28D4528", VA = "0x28D4528")]
	public uint GetRecommendTypeId()
	{
		return default(uint);
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x28D46AC", Offset = "0x28D46AC", VA = "0x28D46AC")]
	public bool IsRecommendType(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x28D4838", Offset = "0x28D4838", VA = "0x28D4838")]
	public bool GetDownloadState(uint tagId)
	{
		return default(bool);
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x28D4988", Offset = "0x28D4988", VA = "0x28D4988")]
	public List<uint> GetNeedAutoDownloadResOptionalReDefIdList(List<uint> tag_id)
	{
		return null;
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x28D4C68", Offset = "0x28D4C68", VA = "0x28D4C68")]
	public void ProcessPatchOptionalResManagerData(List<PatchOptionalResManagerUpdateDesc> PatchOptionalResManagerDataUpdateList)
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x28D5018", Offset = "0x28D5018", VA = "0x28D5018")]
	public List<uint> GetSortedTypeIdList()
	{
		return null;
	}

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x28D521C", Offset = "0x28D521C", VA = "0x28D521C")]
	private static bool _003CGetRecommendTypeId_003Em__0(PatchOptionalTypeManagerData a)
	{
		return default(bool);
	}
}
