using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000240")]
public class TaskData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0xC")]
	public string IconName;

	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x14")]
	public string Desc;

	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID Prefab;

	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x1C")]
	public bool CanDoForbid;

	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x20")]
	public string CivilAlert;

	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x24")]
	public string WolfAlert;

	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x28")]
	public int TaskGroup;

	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x28962C0", Offset = "0x28962C0", VA = "0x28962C0")]
	public TaskData()
	{
	}

	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x2896344", Offset = "0x2896344", VA = "0x2896344", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x28963A8", Offset = "0x28963A8", VA = "0x28963A8", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x2896400", Offset = "0x2896400", VA = "0x2896400", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
