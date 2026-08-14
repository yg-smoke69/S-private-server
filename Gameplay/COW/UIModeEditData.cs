using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E5E")]
public class UIModeEditData
{
	[Token(Token = "0x2002E5F")]
	public class EntranceInfoData
	{
		[Token(Token = "0x4011B6F")]
		[FieldOffset(Offset = "0x8")]
		public string iconUrl;

		[Token(Token = "0x4011B70")]
		[FieldOffset(Offset = "0xC")]
		public ModeVariableBinding offsetX;

		[Token(Token = "0x4011B71")]
		[FieldOffset(Offset = "0x10")]
		public ModeVariableBinding offsetY;

		[Token(Token = "0x4011B72")]
		[FieldOffset(Offset = "0x14")]
		public ModeVariableBinding width;

		[Token(Token = "0x4011B73")]
		[FieldOffset(Offset = "0x18")]
		public ModeVariableBinding height;

		[Token(Token = "0x601364B")]
		[Address(RVA = "0x1309BE0", Offset = "0x1309BE0", VA = "0x1309BE0")]
		public EntranceInfoData()
		{
		}
	}

	[Token(Token = "0x4011B6B")]
	[FieldOffset(Offset = "0x8")]
	public bool IsReady;

	[Token(Token = "0x4011B6C")]
	[FieldOffset(Offset = "0xC")]
	public ModeVariables Variables;

	[Token(Token = "0x4011B6D")]
	[FieldOffset(Offset = "0x10")]
	public IModeEditComponentData ComponentData;

	[Token(Token = "0x4011B6E")]
	[FieldOffset(Offset = "0x14")]
	public EntranceInfoData EntranceInfo;

	[Token(Token = "0x6013649")]
	[Address(RVA = "0x1308B28", Offset = "0x1308B28", VA = "0x1308B28")]
	public UIModeEditData()
	{
	}

	[Token(Token = "0x601364A")]
	[Address(RVA = "0x1308B30", Offset = "0x1308B30", VA = "0x1308B30")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
