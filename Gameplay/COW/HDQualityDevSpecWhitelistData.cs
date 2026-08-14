using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014E")]
public class HDQualityDevSpecWhitelistData : CSVBaseData
{
	[Token(Token = "0x4000864")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0xC")]
	public string strDeviceName;

	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x10")]
	public string strCPU;

	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x14")]
	public string strGPU;

	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x18")]
	public uint[] uRAMRange;

	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x1C")]
	public int processorSize;

	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x20")]
	public bool bUseHDWeaponEffect;

	[Token(Token = "0x400086B")]
	[FieldOffset(Offset = "0x21")]
	public bool bUseHDAudio;

	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x22")]
	public bool bUseHDAnimation;

	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x23")]
	public bool bUseHDLogin;

	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x24")]
	public bool bUseHDLobby;

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x25")]
	public bool bUseHDTexture;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x28")]
	public BJOMPMJHDLC graphicsQuality;

	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x2C")]
	public int[] mapNeoParadiseMaxConfig;

	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x30")]
	public int iSortPriority;

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x12113BC", Offset = "0x12113BC", VA = "0x12113BC")]
	public HDQualityDevSpecWhitelistData()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x1211440", Offset = "0x1211440", VA = "0x1211440", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x12114A4", Offset = "0x12114A4", VA = "0x12114A4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x12117D4", Offset = "0x12117D4", VA = "0x12117D4")]
	private int GetStringCompDistance(string InBase, string InTarget)
	{
		return default(int);
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x12119EC", Offset = "0x12119EC", VA = "0x12119EC")]
	public bool SetupSortPriority(string InCurDeviceName, string InCurCPU, string InCurGPU, int InCurSysMemSize, int InCurProcessorSize)
	{
		return default(bool);
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x1211B5C", Offset = "0x1211B5C", VA = "0x1211B5C")]
	private void SetupSortPriorityForItems(string InCurCPU, string InCurGPU, int InCurSysMemSize, int InCurProcessorSize)
	{
	}
}
