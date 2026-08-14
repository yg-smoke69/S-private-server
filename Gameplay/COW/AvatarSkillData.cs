using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20000AF")]
public class AvatarSkillData : CSVBaseData
{
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x8")]
	private string _003CSkillName_003Ek__BackingField;

	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0xC")]
	private string _003CSkillType_003Ek__BackingField;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x10")]
	private string _003CSkillDesc_003Ek__BackingField;

	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x14")]
	private string _003CSkillParameter6_003Ek__BackingField;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x18")]
	private string _003CChartDesc1_003Ek__BackingField;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CChartParameter1_003Ek__BackingField;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x20")]
	private string _003CChartDesc2_003Ek__BackingField;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x24")]
	private string _003CChartParameter2_003Ek__BackingField;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x28")]
	private string _003CChartParameter3_003Ek__BackingField;

	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x2C")]
	private string _003CChartDesc3_003Ek__BackingField;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x30")]
	private string _003CChartDesc4_003Ek__BackingField;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x34")]
	private string _003CChartParameter4_003Ek__BackingField;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x38")]
	private string _003CAwakenSkillDesc_003Ek__BackingField;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x3C")]
	private string _003CSkillSummary_003Ek__BackingField;

	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x40")]
	private string _003CSkillIconHudStr_003Ek__BackingField;

	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x44")]
	private uint _003CSkillId_003Ek__BackingField;

	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x48")]
	private uint _003CAwakenSkillId_003Ek__BackingField;

	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x4C")]
	private uint _003COriginSkillId_003Ek__BackingField;

	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x50")]
	private int _003CSkillLevel_003Ek__BackingField;

	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x54")]
	private uint _003CAttachedSkill_003Ek__BackingField;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x58")]
	private string _003CSkillSubtype_003Ek__BackingField;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x5C")]
	private float _003CSkillParameter1_003Ek__BackingField;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x60")]
	private float _003CSkillParameter2_003Ek__BackingField;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x64")]
	private float _003CSkillParameter3_003Ek__BackingField;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x68")]
	private float _003CSkillParameter4_003Ek__BackingField;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x6C")]
	private float _003CSkillParameter5_003Ek__BackingField;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x70")]
	private float _003CSkillCheckHackParameter_003Ek__BackingField;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x74")]
	private uint _003CSkillAvatarID_003Ek__BackingField;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x78")]
	private ResourceID _003CSkillIcon_003Ek__BackingField;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x7C")]
	private ResourceID m_SkillIconHud;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x80")]
	public ResourceID OverrideSkillIconHud;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x84")]
	public char SkillIconThemeColor;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x86")]
	private bool _003CIsActiveSkill_003Ek__BackingField;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x88")]
	private uint _003CPriority_003Ek__BackingField;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x8C")]
	private bool _003CIsRecommend_003Ek__BackingField;

	[Token(Token = "0x4000421")]
	public const int InvalidWeaponSubType = -1;

	[Token(Token = "0x4000422")]
	public const int InvalidWeaponType = -1;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x90")]
	private List<Vector2> _003CSkillSubtypeList_003Ek__BackingField;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x94")]
	private bool m_IsZombieMode;

	[Token(Token = "0x170000C2")]
	public string SkillName
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x23599AC", Offset = "0x23599AC", VA = "0x23599AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x23599B4", Offset = "0x23599B4", VA = "0x23599B4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C3")]
	public string SkillType
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x23599BC", Offset = "0x23599BC", VA = "0x23599BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x23599C4", Offset = "0x23599C4", VA = "0x23599C4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C4")]
	public string SkillDesc
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x23599CC", Offset = "0x23599CC", VA = "0x23599CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x23599D4", Offset = "0x23599D4", VA = "0x23599D4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	public string SkillParameter6
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x23599DC", Offset = "0x23599DC", VA = "0x23599DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x23599E4", Offset = "0x23599E4", VA = "0x23599E4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	public string ChartDesc1
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x23599EC", Offset = "0x23599EC", VA = "0x23599EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x23599F4", Offset = "0x23599F4", VA = "0x23599F4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C7")]
	public string ChartParameter1
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x23599FC", Offset = "0x23599FC", VA = "0x23599FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2359A04", Offset = "0x2359A04", VA = "0x2359A04")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C8")]
	public string ChartDesc2
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2359A0C", Offset = "0x2359A0C", VA = "0x2359A0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2359A14", Offset = "0x2359A14", VA = "0x2359A14")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C9")]
	public string ChartParameter2
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2359A1C", Offset = "0x2359A1C", VA = "0x2359A1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2359A24", Offset = "0x2359A24", VA = "0x2359A24")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CA")]
	public string ChartParameter3
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2359A2C", Offset = "0x2359A2C", VA = "0x2359A2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2359A34", Offset = "0x2359A34", VA = "0x2359A34")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CB")]
	public string ChartDesc3
	{
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2359A3C", Offset = "0x2359A3C", VA = "0x2359A3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2359A44", Offset = "0x2359A44", VA = "0x2359A44")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CC")]
	public string ChartDesc4
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2359A4C", Offset = "0x2359A4C", VA = "0x2359A4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2359A54", Offset = "0x2359A54", VA = "0x2359A54")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CD")]
	public string ChartParameter4
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2359A5C", Offset = "0x2359A5C", VA = "0x2359A5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2359A64", Offset = "0x2359A64", VA = "0x2359A64")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CE")]
	public string AwakenSkillDesc
	{
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2359A6C", Offset = "0x2359A6C", VA = "0x2359A6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2359A74", Offset = "0x2359A74", VA = "0x2359A74")]
		private set
		{
		}
	}

	[Token(Token = "0x170000CF")]
	public string SkillSummary
	{
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2359A7C", Offset = "0x2359A7C", VA = "0x2359A7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2359A84", Offset = "0x2359A84", VA = "0x2359A84")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D0")]
	public string SkillIconHudStr
	{
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2359A8C", Offset = "0x2359A8C", VA = "0x2359A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2359A94", Offset = "0x2359A94", VA = "0x2359A94")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D1")]
	public uint SkillId
	{
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x234E6D0", Offset = "0x234E6D0", VA = "0x234E6D0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2359A9C", Offset = "0x2359A9C", VA = "0x2359A9C")]
		set
		{
		}
	}

	[Token(Token = "0x170000D2")]
	public uint AwakenSkillId
	{
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2359AA4", Offset = "0x2359AA4", VA = "0x2359AA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2359AAC", Offset = "0x2359AAC", VA = "0x2359AAC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D3")]
	public uint OriginSkillId
	{
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2359AB4", Offset = "0x2359AB4", VA = "0x2359AB4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2359ABC", Offset = "0x2359ABC", VA = "0x2359ABC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D4")]
	public int SkillLevel
	{
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2359AC4", Offset = "0x2359AC4", VA = "0x2359AC4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2359ACC", Offset = "0x2359ACC", VA = "0x2359ACC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D5")]
	public uint AttachedSkill
	{
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2359AD4", Offset = "0x2359AD4", VA = "0x2359AD4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2359ADC", Offset = "0x2359ADC", VA = "0x2359ADC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D6")]
	public string SkillSubtype
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2359AE4", Offset = "0x2359AE4", VA = "0x2359AE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2359AEC", Offset = "0x2359AEC", VA = "0x2359AEC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D7")]
	public float SkillParameter1
	{
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2359AF4", Offset = "0x2359AF4", VA = "0x2359AF4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2359AFC", Offset = "0x2359AFC", VA = "0x2359AFC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D8")]
	public float SkillParameter2
	{
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2359B04", Offset = "0x2359B04", VA = "0x2359B04")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2359B0C", Offset = "0x2359B0C", VA = "0x2359B0C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000D9")]
	public float SkillParameter3
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2359B14", Offset = "0x2359B14", VA = "0x2359B14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2359B1C", Offset = "0x2359B1C", VA = "0x2359B1C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DA")]
	public float SkillParameter4
	{
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2359B24", Offset = "0x2359B24", VA = "0x2359B24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2359B2C", Offset = "0x2359B2C", VA = "0x2359B2C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DB")]
	public float SkillParameter5
	{
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2359B34", Offset = "0x2359B34", VA = "0x2359B34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2359B3C", Offset = "0x2359B3C", VA = "0x2359B3C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DC")]
	public float SkillCheckHackParameter
	{
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2359B44", Offset = "0x2359B44", VA = "0x2359B44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2359B4C", Offset = "0x2359B4C", VA = "0x2359B4C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DD")]
	public uint SkillAvatarID
	{
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2359B54", Offset = "0x2359B54", VA = "0x2359B54")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2359B5C", Offset = "0x2359B5C", VA = "0x2359B5C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	public ResourceID SkillIcon
	{
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x23594C4", Offset = "0x23594C4", VA = "0x23594C4")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2359B64", Offset = "0x2359B64", VA = "0x2359B64")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DF")]
	public ResourceID SkillIconHud
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2359B6C", Offset = "0x2359B6C", VA = "0x2359B6C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x170000E0")]
	public bool IsActiveSkill
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2359C60", Offset = "0x2359C60", VA = "0x2359C60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2359C68", Offset = "0x2359C68", VA = "0x2359C68")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E1")]
	public uint Priority
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2359C70", Offset = "0x2359C70", VA = "0x2359C70")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2359C78", Offset = "0x2359C78", VA = "0x2359C78")]
		private set
		{
		}
	}

	[Token(Token = "0x170000E2")]
	public bool IsRecommend
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2359C80", Offset = "0x2359C80", VA = "0x2359C80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2359C88", Offset = "0x2359C88", VA = "0x2359C88")]
		set
		{
		}
	}

	[Token(Token = "0x170000E3")]
	public List<Vector2> SkillSubtypeList
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2359C90", Offset = "0x2359C90", VA = "0x2359C90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2359C98", Offset = "0x2359C98", VA = "0x2359C98")]
		private set
		{
		}
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x23598D4", Offset = "0x23598D4", VA = "0x23598D4")]
	public AvatarSkillData()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x2359CA0", Offset = "0x2359CA0", VA = "0x2359CA0")]
	public void SetZombieMode()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x2359CFC", Offset = "0x2359CFC", VA = "0x2359CFC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x2359D78", Offset = "0x2359D78", VA = "0x2359D78", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x235AB74", Offset = "0x235AB74", VA = "0x235AB74")]
	public void ProcessSkillSubType()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x235AED4", Offset = "0x235AED4", VA = "0x235AED4")]
	public string GetLevelUpDesc()
	{
		return null;
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x235BFB0", Offset = "0x235BFB0", VA = "0x235BFB0")]
	public string GetSpSkillDesc()
	{
		return null;
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x235BE14", Offset = "0x235BE14", VA = "0x235BE14")]
	private string BuildTempLevelStr(float u1, float u2)
	{
		return null;
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x235C924", Offset = "0x235C924", VA = "0x235C924")]
	private string BuildColorStr(float u1)
	{
		return null;
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x235C804", Offset = "0x235C804", VA = "0x235C804")]
	private string BuildNewColorStr(float u1)
	{
		return null;
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x235CA44", Offset = "0x235CA44", VA = "0x235CA44")]
	private string BuildColorStr2(float u1, float u2)
	{
		return null;
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x235CB74", Offset = "0x235CB74", VA = "0x235CB74")]
	public string GetSkillDesc()
	{
		return null;
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x235D480", Offset = "0x235D480", VA = "0x235D480")]
	public string GetColorSkillDesc()
	{
		return null;
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x235DC94", Offset = "0x235DC94", VA = "0x235DC94")]
	public bool LevelMax()
	{
		return default(bool);
	}
}
