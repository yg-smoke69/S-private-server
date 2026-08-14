using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001DD7")]
public class DevSpecWhitelistData : CSVBaseData
{
	[Token(Token = "0x2001DD8")]
	public enum FramerateType
	{
		[Token(Token = "0x400BD08")]
		F_30,
		[Token(Token = "0x400BD09")]
		F_60,
		[Token(Token = "0x400BD0A")]
		F_90
	}

	[Token(Token = "0x400BCF3")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x400BCF4")]
	[FieldOffset(Offset = "0xC")]
	public string strDeviceName;

	[Token(Token = "0x400BCF5")]
	[FieldOffset(Offset = "0x10")]
	public string strOS;

	[Token(Token = "0x400BCF6")]
	[FieldOffset(Offset = "0x14")]
	public string strCPU;

	[Token(Token = "0x400BCF7")]
	[FieldOffset(Offset = "0x18")]
	public string strGPU;

	[Token(Token = "0x400BCF8")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] uRAMRange;

	[Token(Token = "0x400BCF9")]
	[FieldOffset(Offset = "0x20")]
	public GAGILKKDDMJ eQualityLevel;

	[Token(Token = "0x400BCFA")]
	[FieldOffset(Offset = "0x24")]
	public BJOMPMJHDLC eGraphicLevel;

	[Token(Token = "0x400BCFB")]
	[FieldOffset(Offset = "0x28")]
	public BJOMPMJHDLC eMapDesertGraphicLevel;

	[Token(Token = "0x400BCFC")]
	[FieldOffset(Offset = "0x2C")]
	public bool bShowHighFramerateUI;

	[Token(Token = "0x400BCFD")]
	[FieldOffset(Offset = "0x30")]
	public FramerateType eHighFramerateDefault;

	[Token(Token = "0x400BCFE")]
	[FieldOffset(Offset = "0x34")]
	public bool bEnableRTShadow;

	[Token(Token = "0x400BCFF")]
	[FieldOffset(Offset = "0x35")]
	public bool bEnableHDGraphics;

	[Token(Token = "0x400BD00")]
	[FieldOffset(Offset = "0x38")]
	public int iUnloadTime;

	[Token(Token = "0x400BD01")]
	[FieldOffset(Offset = "0x3C")]
	public int iUnloadMemory;

	[Token(Token = "0x400BD02")]
	[FieldOffset(Offset = "0x40")]
	public bool bLowMemeoryIOS;

	[Token(Token = "0x400BD03")]
	[FieldOffset(Offset = "0x44")]
	public int iSortPriority;

	[Token(Token = "0x400BD04")]
	[FieldOffset(Offset = "0x48")]
	public float resolutionReduceRate;

	[Token(Token = "0x400BD05")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsBountyForceUseLowResource;

	[Token(Token = "0x400BD06")]
	[FieldOffset(Offset = "0x4D")]
	public bool bUnloadEmbeddedSceneObjects;

	[Token(Token = "0x6008E8E")]
	[Address(RVA = "0x1C8FB90", Offset = "0x1C8FB90", VA = "0x1C8FB90")]
	public DevSpecWhitelistData()
	{
	}

	[Token(Token = "0x6008E8F")]
	[Address(RVA = "0x1C8FC64", Offset = "0x1C8FC64", VA = "0x1C8FC64", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6008E90")]
	[Address(RVA = "0x1C8FCC8", Offset = "0x1C8FCC8", VA = "0x1C8FCC8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6008E91")]
	[Address(RVA = "0x1C901B4", Offset = "0x1C901B4", VA = "0x1C901B4")]
	private int GetStringCompDistance(string InBase, string InTarget)
	{
		return default(int);
	}

	[Token(Token = "0x6008E92")]
	[Address(RVA = "0x1C903CC", Offset = "0x1C903CC", VA = "0x1C903CC")]
	public bool SetupSortPriority(string InCurDeviceName, string InCurCPU, string InCurGPU, int InCurSysMemSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6008E93")]
	[Address(RVA = "0x1C90524", Offset = "0x1C90524", VA = "0x1C90524")]
	private void SetupSortPriorityForItems(string InCurCPU, string InCurGPU, int InCurSysMemSize)
	{
	}

	[Token(Token = "0x6008E94")]
	[Address(RVA = "0x1C907A4", Offset = "0x1C907A4", VA = "0x1C907A4")]
	private bool SpecialStringCheck(string strGPU, string InCurGPU)
	{
		return default(bool);
	}
}
