using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026D")]
public class WereWolvesRoleData : CSVBaseData
{
	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID IconResID;

	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID RolePrefebResId;

	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID BodyPrefebResId;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x18")]
	public string IdleAnim;

	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0x1C")]
	public string WalkAnim;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x20")]
	public string KillAnim;

	[Token(Token = "0x4000EC7")]
	[FieldOffset(Offset = "0x24")]
	public string InTrapAnimLoop;

	[Token(Token = "0x4000EC8")]
	[FieldOffset(Offset = "0x28")]
	public string EnterTrapAnim;

	[Token(Token = "0x4000EC9")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID WalkSFXResId;

	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x21B95B0", Offset = "0x21B95B0", VA = "0x21B95B0")]
	public WereWolvesRoleData()
	{
	}

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x21B9634", Offset = "0x21B9634", VA = "0x21B9634", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x21B9698", Offset = "0x21B9698", VA = "0x21B9698", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
